function Start () {
 
  gameObject.GetComponent.<Animation>().wrapMode = WrapMode.Loop;
 
  gameObject.GetComponent.<Animation>().Play("blade_col1");
  gameObject.GetComponent.<Animation>().Play("blade1");
  
  }