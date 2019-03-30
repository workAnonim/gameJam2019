function Start () {
 
  gameObject.GetComponent.<Animation>().wrapMode = WrapMode.Loop;
 
  gameObject.GetComponent.<Animation>().Play("stake1a");
  gameObject.GetComponent.<Animation>().Play("stake1b");
    
  }