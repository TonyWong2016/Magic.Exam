$(function () {
    var l = abp.localization.getResource('Exam');

    var dataTable = $("#ExaminationsTable").DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(magic.exam.examinations.examination.getList),
            columnDefs: [
                {
                    title: l("Title"),
                    data: "title"
                },
                {
                    title: l("StartTime"),
                    data: "startTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                },
                {
                    title: l("EndTime"),
                    data: "endTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                },
                {
                    title: l("BaseDuration"),
                    data: "baseDuration"
                },
                {
                    title: l('ExamType'),
                    data: "examType",
                    render: function (data) {
                        let color = "#adb5bd";
                        if (data == 1) {
                            color = '#0dcaf0';
                        } else if (data == 2) {
                            color = '#20c997';
                        }
                        let output = `<b style="color:${color}">${l('Enum:ExaminationType:' + data)}</b>`;
                        
                        return output;
                    }
                },
                {
                    title: l('CreationTime'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    }
                }
            ]
        })
    );

    //创建
    var createModel = new abp.ModalManager(abp.appPath + 'Examinations/CreateModal');
    createModel.onResult(function () {
        dataTable.ajax.reload();
    })

    $("#NewExaminationButton").click(function (e) {
        e.preventDefault();
        createModel.open();
    })
});