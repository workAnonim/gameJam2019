function Start () {
 
  gameObject.GetComponent.<Animation>().wrapMode = WrapMode.Loop;
 
  gameObject.GetComponent.<Animation>().Play("trunk_col2");
  gameObject.GetComponent.<Animation>().Play("trunk2");
  
  }