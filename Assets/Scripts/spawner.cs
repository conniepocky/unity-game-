using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    
    public bool i_am_the_mother_cube = true;
    public score s;
    public gameOver go;

    void Start()
    {
	if (i_am_the_mother_cube) {
		for (int j = 0; j < 3; j++) {
			float y = transform.position.y + 1.2f * j;
			for (int i = 0; i < 5; i++) {
				float x = transform.position.x - 1.2f * i;
				GameObject _temp = Instantiate(gameObject, new Vector3(x, y, 0), Quaternion.identity);
				_temp.GetComponent<spawner>().i_am_the_mother_cube = false;

			}
		}	
		Destroy(gameObject);
	}
    }

    private void OnCollisionEnter(Collision collision) {
	    s.scoreText.text = s.points.ToString();
	    s.points += 1;

            if (s.points == 15) {
	    	go.callGameOver();
	    }

 	    Destroy(gameObject);
    }	    

    // Update is called once per frame
    void Update()
    {
        
    }
}
