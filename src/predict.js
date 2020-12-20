const Result = {
	0 : "Benign",
	1 : "Malignant"
}
$(document).ready(function(){
	$("#image-selector").change(function () {
	
		let reader = new FileReader();
		reader.onload = function () {
			let dataURL = reader.result;
			$("#selected-image").attr("src", dataURL);
			$("#prediction-list").empty();
		}
	
		let file = $("#image-selector").prop('files')[0];
		reader.readAsDataURL(file);
	});

});


let model;
$(document).ready(async function () {

	
	$('.progress-bar').show();
	model = await tf.automl.loadImageClassification('model/model.json')
	$('.progress-bar').hide();

});

$(document).ready(function(){
	$("#predictBtn").click(async function () {
		let image = $('#selected-image').get(0);
		
		let pre_image = tf.browser.fromPixels(image, 3)
			.resizeNearestNeighbor([224,224])
			.expandDims()
			.toFloat()
			.reverse(-1); 
		let predict_result = await model.classify(image);
		console.log(predict_result);
		
		document.getElementById("prediction-benign").innerText=predict_result['0']['label']+": "+Math.round(predict_result['0']['prob']*100)+"%";
 		document.getElementById("prediction-malignant").innerText=predict_result['1']['label']+": "+Math.round(predict_result['1']['prob']*100)+"%";	
	});
});



