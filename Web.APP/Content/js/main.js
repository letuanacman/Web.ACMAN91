const inputs = document.querySelectorAll(".input");

function addcl() {
	let parent = this.parentNode.parentNode;
	parent.classList.add("focus");
}

function remcl(){
	let parent = this.parentNode.parentNode;
	if(this.value == ""){
		parent.classList.remove("focus");
	}
}

$(function ()
{
	$('#AlertBox').removeClass('hide');
	$('#ALertBox').delay(1000).slideUp(500);
})

inputs.forEach(input => {
	input.addEventListener("focus", addcl);
	input.addEventListener("blur", remcl);
});
