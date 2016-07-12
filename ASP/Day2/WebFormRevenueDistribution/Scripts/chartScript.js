draw = function (chartType, LabelRecoveryCost, LabelGovernmentTake, LabelOilCompanyTake) {
    var chart = new CanvasJS.Chart("chartContainer", {
        title: {
            text: "My First Chart in CanvasJS"
        },
        data: [
		{
		    // Change type to "doughnut", "line", "splineArea", etc.
		    type: chartType,
		    dataPoints: [
				{ label: "Recovery Cost", y: parseFloat(LabelRecoveryCost) },
                { label: "Government Take", y: parseFloat(LabelGovernmentTake) },
                { label: "Oil Company Take", y: parseFloat(LabelOilCompanyTake) },
				
		    ]
		}
        ]
    });
    chart.render();
}