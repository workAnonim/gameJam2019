function Start () {
 
  gameObject.GetComponent.<Animation>().wrapMode = WrapMode.Loop;
 
  gameObject.GetComponent.<Animation>().Play("arm");
  gameObject.GetComponent.<Animation>().Play("trunk");
  
  }