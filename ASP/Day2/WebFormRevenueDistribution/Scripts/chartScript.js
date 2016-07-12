draw = function (chartType,RecoveryCost) {
    var chart = new CanvasJS.Chart("chartContainer", {
        title: {
            text: "My First Chart in CanvasJS"
        },
        data: [
		{
		    // Change type to "doughnut", "line", "splineArea", etc.
		    type: chartType,
		    dataPoints: [
				{ label: "apple", y: parseFloat(RecoveryCost) },
				
		    ]
		}
        ]
    });
    chart.render();
}