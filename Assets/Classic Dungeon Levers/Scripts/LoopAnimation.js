#pragma strict
var anim1 : String;
var anim2 : String;
var curAnim : int = 1;

function Start () {
	GetComponent.<Animation>().Play(anim1);
	GetComponent.<Animation>().wrapMode = WrapMode.Once;
}
function Update() {
	if(curAnim == 1) {
		if(!GetComponent.<Animation>().isPlaying) {
			GetComponent.<Animation>().CrossFade(anim2);
			GetComponent.<Animation>().wrapMode = WrapMode.Once;
			curAnim = 2;
		}
	}
	else {
		if(curAnim == 2) {
			if(!GetComponent.<Animation>().isPlaying) {
				GetComponent.<Animation>().CrossFade(anim1);
				GetComponent.<Animation>().wrapMode = WrapMode.Once;
				curAnim = 1;
			}
		}
	}
}