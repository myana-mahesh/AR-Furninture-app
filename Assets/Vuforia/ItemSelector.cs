using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class ItemSelector : MonoBehaviour
{
	

	   /*  public GameObject Table;
		public GameObject Chair;
		public GameObject Bed;
	    public GameObject Wadrobe;
	    public GameObject Sofa;*/
		public GameObject Bed;
		public GameObject Sofa;
		

		// Use this for initialization
		void Start () {
			/* Table.SetActive (true);
			Chair.SetActive (false);
		Bed.SetActive (false);
		Wadrobe.SetActive (false);
		Sofa.SetActive (false);*/
		Bed.SetActive(false);
		Sofa.SetActive(false);



		}

		/* public void LoadTable(){
			Table.SetActive (true);
			Chair.SetActive (false);
			Wadrobe.SetActive (false);
		Sofa.SetActive (false);
		Bed.SetActive(false);


		}

		public void LoadChair(){
		Chair.SetActive (true);
		Table.SetActive (false);
		Wadrobe.SetActive (false);
		Sofa.SetActive (false);
		Bed.SetActive(false);


					}

		public void LoadBed(){
			
		Bed.SetActive (true);
		Chair.SetActive (false);
		Wadrobe.SetActive (false);
		Sofa.SetActive (false);
		Table.SetActive(false);
		}
	public void LoadWadrobe(){
		Wadrobe.SetActive (true);
		Chair.SetActive (false);
		Table.SetActive (false);
		Sofa.SetActive (false);
		Bed.SetActive(false);
			}*/

	public void LoadSofa(){
		/* Sofa.SetActive (true);
		Chair.SetActive (false);
		Table.SetActive (false);
		Wadrobe.SetActive (false);
		Bed.SetActive(false);	*/
		Sofa.SetActive(true);
		
		
	}

	public void LoadBed(){
		Bed.SetActive(true);
	}

}
