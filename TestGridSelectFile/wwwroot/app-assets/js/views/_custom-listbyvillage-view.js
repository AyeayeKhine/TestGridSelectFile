"use strict";
window.MRCS = window.MRCS || {};
MRCS.HouseHoldMemberList = function () {
    var self = this,

        loadOptions = {
            key: "ID",
            baseURL: "/Population/HouseHoldMember/GetByCustomFilter"
        },
        componentId = "#HouseHoldMemberGrid",
        gridOption = {};


    self.init = function () {
        MRCS.loadData("/Population/HouseHoldMember/CheckAuthorized", "json", "GET", "application/x-www-form-urlencoded")
            .then(function (result) {

                var accessRight = result;

                gridOption = self.GetGridOption(accessRight);

                if ($(componentId).data('parentid')) {
                    loadOptions = {
                        key: "ID",
                        baseURL: $(componentId).data('url')
                    };
                    if ($(componentId).data('parentpropertyname')) {
                        loadOptions.baseURL = loadOptions.baseURL + '?' + $(componentId).data('parentpropertyname') + '=' + $(componentId).data('parentid');
                    }
                } else if ($(componentId).data('url')) {
                    loadOptions = {
                        key: "ID",
                        baseURL: $(componentId).data('url')
                    };
                }

                MRCS.SharedWidgets.initGrid(gridOption, componentId, function (grid) {
                    grid.load(loadOptions);
                });

            });

        $("#SubTitle").text(MRCS.Functions.GetUrlSearchParam("ListTitle"));
    };
    self.GetGridOption = function (accessRight) {
        return {
            selection: {
                mode: "multiple"
            },
            columns: [

                { dataField: "ID", caption: "MemberID", headerFilter: false, sortIndex: 0, sortOrder: "desc", visible: false },
                { dataField: "Name", caption: "Name", headerFilter: false },

                { dataField: "Salary", caption: "Salary", headerFilter: false },

                {
                    dataField: "Gender", caption: "Gender", headerFilter: false
                },

                { dataField: "City", caption: "City", headerFilter: false, allowSearch: false },
            ],
            onRowDblClick: function (e) {
                if (e.rowType === "data") {
                    if (accessRight.Detail) {
                        window.location.href = '/Population/HouseHoldMember/Detail?id=' + e.key;
                    }
                }
            },
            onToolbarPreparing: function (e) {
                var dataGrid = e.component;
                var d = $.Deferred();

                e.toolbarOptions.items.unshift(
                    {
                        widget: "dxButton",
                        location: "before",
                        toolbar: 'bottom',
                        options: {
                            stylingMode: "contained",
                            text: "Select",
                            type: "default",
                            onClick: function onClick() {
                                var selectedFormData = dataGrid.getSelectedRowsData();
                                var selectedhouseHoldMemberList;
                                var id = new URL(window.location.href).searchParams.get('id');
                                var villageId = new URL(window.location.href).searchParams.get('valliageid');
                                var volunteerId = new URL(window.location.href).searchParams.get('Volunteerid');
                                var ProjectActivityCode = new URL(window.location.href).searchParams.get('DocumentCode');
                                var ProjectActivityDescription = new URL(window.location.href).searchParams.get('DocumentDescription');
                                var module = new URL(window.location.href).searchParams.get('Module');
                                var params = {};
                                var url = "";
                                if (selectedFormData.length > 0) {
                                    selectedhouseHoldMemberList = selectedFormData[0].HouseHoldMemberID;
                                }
                                for (var i = 1; i < selectedFormData.length; i++) {

                                    selectedhouseHoldMemberList += "," + selectedFormData[i].HouseHoldMemberID;
                                }

                                if (module === "ProjectReferrral") {

                                    params = {
                                        projectReferralId: id,
                                        selectedhouseHoldMemberList: selectedhouseHoldMemberList
                                    };
                                    url = "/Project/ProjectReferralHouseHoldMember/CreateList";
                                    MRCS.loadData(url, "json", "Post", "application/x-www-form-urlencoded", params, null)
                                        .then(function (result) {
                                            d.resolve(result);
                                            window.location.href = '/Project/ProjectReferral/Detail?id=' + id;
                                        });

                                } else {
                                    params = {
                                        projectActivityId: id,
                                        volunteerId: volunteerId,
                                        selectedhouseHoldMemberList: selectedhouseHoldMemberList
                                    };
                                    url = "/Project/ProjectActivityDetail/CreateList";
                                    MRCS.loadData(url, "json", "Post", "application/x-www-form-urlencoded", params, null)
                                        .then(function (result) {
                                            d.resolve(result);
                                            window.location.href = '/Project/ProjectActivity/Detail?id=' + id;
                                        });
                                }

                            }
                        }
                    }, {
                    widget: "dxButton",
                    location: "before",
                    toolbar: 'bottom',
                    options: {
                        stylingMode: "contained",
                        text: "Cancel",
                        type: "normal",
                        onClick: function onClick(e) {

                        }
                    }
                },
                    {
                        location: "before",
                        widget: "dxButton",
                        widgetId: "Reset",
                        locateInMenu: "auto",
                        options: {
                            hint: "Reset layout",
                            icon: "fa fa-history",
                            onClick: function () {
                                dataGrid.state({});
                            }
                        }
                    },

                    {
                        location: "before",
                        widget: "dxButton",
                        widgetId: "export",
                        locateInMenu: "auto",
                        options: {
                            hint: "export data to excel",
                            icon: "export",
                            onClick: function (e) {

                                var filter = dataGrid.getCombinedFilter();
                                var sort = dataGrid.getController("data").dataSource().sort();
                                var exportColumns = MRCS.Functions.GetVisibleColumnsList(dataGrid.getVisibleColumns());
                                var dynamicFilter = MRCS.Functions.GetUrlSearchParam("DynamicFilter");
                                var params = {
                                    filter: JSON.stringify(filter),
                                    sort: JSON.stringify(sort),
                                    SelectedExportColumns: JSON.stringify(exportColumns),
                                    dynamicFilter: dynamicFilter !== null && dynamicFilter.lenght > 0 ? JSON.stringify(dynamicFilter) : dynamicFilter
                                }

                                MRCS.Functions.DownloadFile("/Population/HouseHoldMember/ExportToExcel", params);
                            }
                        }
                    },
                    {
                        location: "before",
                        widget: "dxButton",
                        widgetId: "Archive",
                        locateInMenu: "auto",
                        options: {
                            hint: "Archive List",
                            icon: "fa fa-archive",
                            visible: accessRight.Restore,
                            onClick: function () {
                                window.open("/Population/HouseHoldMember/History?IsArchive=true");
                            }
                        }
                    },
                    {
                        location: "before",
                        widget: "dxButton",
                        widgetId: "Refresh",
                        locateInMenu: "auto",
                        options: {
                            hint: "Refresh",
                            icon: "refresh",
                            onClick: function () {
                                dataGrid.refresh();
                            }
                        }
                    },

                );
            },
            onSelectionChanged: function (e) {
                var grid = e.component;
                var selectedKeys = e.currentSelectedRowKeys;
                var deselectedKeys = e.currentDeselectedRowKeys;

                for (var i = 0; i < selectedKeys.length; i++) {
                    //grid.cellValue(grid.getRowIndexByKey(selectedKeys[i]), "Perform", true);
                    //grid.cellValue(grid.getRowIndexByKey(selectedKeys[i]), "New", true);
                    //grid.cellValue(grid.getRowIndexByKey(selectedKeys[i]), "Edit", true);
                    //grid.cellValue(grid.getRowIndexByKey(selectedKeys[i]), "Remove", true);
                    //grid.cellValue(grid.getRowIndexByKey(selectedKeys[i]), "List", true);
                    //grid.cellValue(grid.getRowIndexByKey(selectedKeys[i]), "Detail", true);

                }

                for (var i = 0; i < deselectedKeys.length; i++) {
                    //grid.cellValue(grid.getRowIndexByKey(deselectedKeys[i]), "Perform", false);
                    //grid.cellValue(grid.getRowIndexByKey(deselectedKeys[i]), "New", false);
                    //grid.cellValue(grid.getRowIndexByKey(deselectedKeys[i]), "Edit", false);
                    //grid.cellValue(grid.getRowIndexByKey(deselectedKeys[i]), "Remove", false);
                    //grid.cellValue(grid.getRowIndexByKey(deselectedKeys[i]), "List", false);
                    //grid.cellValue(grid.getRowIndexByKey(deselectedKeys[i]), "Detail", false);

                }
            }
        }
    };
};
$(function () {
    MRCS.HouseHoldMemberList = new MRCS.HouseHoldMemberList();
    MRCS.HouseHoldMemberList.init();
});
