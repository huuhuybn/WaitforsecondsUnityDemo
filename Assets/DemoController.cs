using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoController : MonoBehaviour
{

    public GameObject phaoHoa;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }
    
    
    IEnumerator ExampleCoroutine()
    {
       
        yield return new WaitForSeconds(5);
        // sau khi chờ 5s thì thêm đối tượng pháo hoá vào vị trí chính giữa màn hình 
        // với các thuộc tính mặc định 
        Instantiate(phaoHoa, transform.position, Quaternion.identity); 


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
