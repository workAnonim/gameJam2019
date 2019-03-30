#pragma strict


function OnTriggerEnter (obj : Collider) {
	var thespikes = gameObject.FindWithTag("spikes");
	thespikes.GetComponent.<Animation>().Play("spikes");
}