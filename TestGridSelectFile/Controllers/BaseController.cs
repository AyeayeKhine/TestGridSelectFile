using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Text.Json;

namespace TestGridSelectFile.Controllers
{
    public class BaseController : Controller
    {
        protected void GetFilterText(Type modelType, IList filterList, ref string filterText)
        {
            try
            {
                if (filterList[0].ToString().Contains("]"))
                {

                    foreach (var item in filterList)
                    {
                        if (item.ToString().Contains("]"))
                        {
                            var childList = JsonSerializer.Deserialize<IList>(item.ToString());

                            //filterText = item;

                            if (childList.Count > 1)
                            {
                                if (childList[0].ToString().Contains("]"))
                                {
                                    filterText = filterText + "(";
                                    GetFilterText(modelType, childList, ref filterText);
                                    filterText = filterText + ")";
                                }
                                else
                                {
                                    if (childList[0].ToString().Length == 1)
                                    {
                                        filterText = filterText + childList[0].ToString();
                                        if (childList[1].ToString().Contains("]"))
                                        {
                                            filterText = filterText + "(";
                                            GetFilterText(modelType, JsonSerializer.Deserialize<IList>(childList[1].ToString()), ref filterText);
                                            filterText = filterText + ")";
                                        }
                                    }
                                    else
                                    {
                                        filterText = filterText + GetFilterStatement(modelType, childList[0].ToString(), childList[1].ToString(), childList[2].ToString());
                                    }
                                }

                            }
                            else
                            {
                                filterText = filterText.EndsWith(")") ? filterText + " " + childList[0].ToString().ToUpper() + " " : filterText;
                                //filterText = filterText + " " + childList[0].ToString().ToUpper() + " ";
                            }
                        }
                        else
                        {
                            filterText = filterText.EndsWith(")") ? filterText + " " + item.ToString().ToUpper() + " " : filterText;
                            //filterText = filterText + " " + item.ToString().ToUpper() + " ";
                        }
                    }
                }
                else
                {
                    if (filterList.Count == 1)
                    {
                        filterText = filterText.EndsWith(")") ? filterText + " " + filterList[0].ToString().ToUpper() + "" : filterText;
                    }
                    else if (filterList.Count == 3)
                    {
                        filterText = filterText + GetFilterStatement(modelType, filterList[0].ToString(), filterList[1].ToString(), filterList[2].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected string GetFilterStatement(Type modelType, string propertyName, string valueCompare, string value)
        {
            string result = "";
            Dictionary<string, string> compareList = new Dictionary<string, string>();
            compareList.Add("contains", "({0}.Contains({1}))");
            compareList.Add("notcontains", "(!{0}.Contains({1}))");
            compareList.Add("startswith", "({0}.StartsWith({1}))");
            compareList.Add("endswith", "({0}.EndsWith({1}))");
            compareList.Add("=", "({0} = {1})");
            compareList.Add("<>", "({0} != {1})");
            compareList.Add(">=", "({0} >= {1})");
            compareList.Add("<", "({0} < {1})");
            compareList.Add("=<", "({0} =< {1})");
            compareList.Add(">", "({0} > {1})");
            compareList.Add("<=", "({0} <= {1})");

            var property = modelType.GetProperties().Where(p => p.Name == propertyName).FirstOrDefault();
            if (property != null)
            {
                if (property.PropertyType == typeof(string))
                {
                    result = string.Format(compareList[valueCompare], propertyName, "\"" + value + "\"");
                }
                else if (property.PropertyType == typeof(DateTime) || property.PropertyType == typeof(DateTime?))
                {
                    result = string.Format(compareList[valueCompare], propertyName, "DateTime.Parse(\"" + value + "\")");
                }
                else if ((property.PropertyType == typeof(Guid) || property.PropertyType == typeof(Guid?)) && valueCompare == "contains") // filter from search box
                {
                    result = string.Format(compareList[valueCompare], propertyName.Replace("ID", "Code", false, System.Globalization.CultureInfo.CurrentCulture), "\"" + value + "\"");
                    result = result + " OR " + string.Format(compareList[valueCompare], propertyName.Replace("ID", "Description", false, System.Globalization.CultureInfo.CurrentCulture), "\"" + value + "\"");
                }
                else if ((property.PropertyType == typeof(Guid) || property.PropertyType == typeof(Guid?))) // filter from column
                {
                    result = string.Format(compareList[valueCompare], propertyName, "\"" + value + "\"");

                }
                else if ((property.PropertyType == typeof(byte) || property.PropertyType == typeof(byte?))) // filter from column
                {
                    result = string.Format(compareList[valueCompare], propertyName, value);
                }
                else if ((property.PropertyType == typeof(bool) || property.PropertyType == typeof(bool?))) // filter from column
                {
                    result = string.Format(compareList[valueCompare], propertyName, value);
                }
                else
                {
                    result = string.Format(compareList[valueCompare], propertyName, value);
                }
            }

            return result;
        }
    }
}
