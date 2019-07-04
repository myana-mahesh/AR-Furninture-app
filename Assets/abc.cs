using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abc : MonoBehaviour
{
    public GameObject Bed;
		public GameObject Sofa;
		public GameObject Chair;
		public GameObject Wadrobe;
		

		// Use this for initialization
		void Start () {
		Bed.SetActive(false);
		Sofa.SetActive(false);
		Chair.SetActive(false);
		Wadrobe.SetActive(false);
        }
        public void Update(){
            
        }
        public void LoadSofa(){
            Sofa.SetActive(true);
										Bed.SetActive(false);
										Chair.SetActive(false);
										Wadrobe.SetActive(false);
        }
        public void LoadChair(){
            Sofa.SetActive(false);
										Bed.SetActive(false);
										Chair.SetActive(true);
										Wadrobe.SetActive(false);
        }
        public void LoadBed(){
            Sofa.SetActive(false);
										Bed.SetActive(true);
										Chair.SetActive(false);
										Wadrobe.SetActive(false);
        }
        public void LoadWadrobe(){
            Sofa.SetActive(false);
										Bed.SetActive(false);
										Chair.SetActive(false);
										Wadrobe.SetActive(true);
        }
}

