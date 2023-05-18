$(document).ready(function () {
    MultiselectHelper.Genratemultiselectcombo();

});

var Multiselect_Manager = {

};

var MultiselectHelper = {
    Genratemultiselectcombo:function() {
        $("#cmbcountry").kendoMultiselecrt({
            palceholder: " Select Country",
            dataTextField: "Name",
            dataValueField: "ID",
            datasource: [{ id: 1, Name: "India" }, { id: 2, Name: "China" }, { id: 3, Name: "Russia" }],
            filter: "contains"

        });
    }
}