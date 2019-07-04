using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class se : MonoBehaviour
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
			if(Chair.active==true && Wadrobe.active==true && Bed.active==true){
										Sofa.SetActive(true);
										Bed.SetActive(true);
										Chair.SetActive(true);
										Wadrobe.SetActive(true);
			}	
			else{
						if(Chair.active==true && Bed.active==true){
							Sofa.SetActive(true);
							Bed.SetActive(true);
							Chair.SetActive(true);
							Wadrobe.SetActive(false);
						}
						else{
							if(Chair.active==true&&Wadrobe.active==true){
								Sofa.SetActive(true);
								Bed.SetActive(false);
								Chair.SetActive(true);
								Wadrobe.SetActive(true);	
							}
							else{
								if(Bed.active==true&&Wadrobe.active==true){
									Sofa.SetActive(true);
									Bed.SetActive(true);
									Chair.SetActive(false);
									Wadrobe.SetActive(true);	
								}						
								else{	
									
									
									if(Bed.active==true) {
				Sofa.SetActive(true);
				Bed.SetActive(true);
				Chair.SetActive(false);	
				Wadrobe.SetActive(false);
			}
			else{
				if(Chair.active==true){
					Sofa.SetActive(true);
					Bed.SetActive(false);
					Chair.SetActive(true);
					Wadrobe.SetActive(false);
				}
				else{
					if(Wadrobe.active==true){
						Sofa.SetActive(true);
						Bed.SetActive(false);
						Chair.SetActive(false);
						Wadrobe.SetActive(true);
					}
			
					
								
									
				
									else{

										Sofa.SetActive(true);
										Bed.SetActive(false);
										Chair.SetActive(false);
										Wadrobe.SetActive(false);
		
	  								 }
								}
							}	
						}
					}
				}
			}
		}
	    public void LoadBed(){
			if(Chair.active==true && Wadrobe.active==true && Sofa.active==true){
				Sofa.SetActive(true);
				Bed.SetActive(true);
				Chair.SetActive(true);
				Wadrobe.SetActive(true);
			}	
									
			else{
				if(Chair.active==true && Sofa.active==true){
							Sofa.SetActive(true);
							Bed.SetActive(true);
							Chair.SetActive(true);
							Wadrobe.SetActive(false);
						}
						else{
							if(Chair.active==true&&Wadrobe.active==true){
								Sofa.SetActive(false);
								Bed.SetActive(true);
								Chair.SetActive(true);
								Wadrobe.SetActive(true);	
							}
							else{
								if(Sofa.active==true&&Wadrobe.active==true){
									Sofa.SetActive(true);
									Bed.SetActive(true);
									Chair.SetActive(false);
									Wadrobe.SetActive(true);	
								}								
								else{
				if(Chair.active==true){
					Sofa.SetActive(false);
					Bed.SetActive(true);
					Chair.SetActive(true);
					Wadrobe.SetActive(false);
				}
				else{
					if(Wadrobe.active==true){
						Sofa.SetActive(false);
						Bed.SetActive(true);
						Chair.SetActive(false);
						Wadrobe.SetActive(true);
					}	
									
					
								else{				
									
									
									
									if(Sofa.active==true) {
				Sofa.SetActive(true);
				Bed.SetActive(true);
				Chair.SetActive(false);	
				Wadrobe.SetActive(false);
			}
			
			
					
									
				
									else{

										Sofa.SetActive(false);
										Bed.SetActive(true);
										Chair.SetActive(false);
										Wadrobe.SetActive(false);

	  								 }
								}
							}
						}
					}
				}
			}
		}
		public void LoadChair(){
			if(Sofa.active==true && Wadrobe.active==true && Bed.active==true){
			Sofa.SetActive(true);
			Bed.SetActive(true);
			Chair.SetActive(true);
			Wadrobe.SetActive(true);
			}	
			else{
				if(Sofa.active==true && Bed.active==true){
					Sofa.SetActive(true);
					Bed.SetActive(true);
					Chair.SetActive(true);
					Wadrobe.SetActive(false);
				}	
				else{
					if(Sofa.active==true&&Chair.active==true){
						Sofa.SetActive(true);
						Bed.SetActive(false);
						Chair.SetActive(true);
						Wadrobe.SetActive(true);	
					}	


					else{
						if(Bed.active==true&&Chair.active==true){
							Sofa.SetActive(false);
							Bed.SetActive(true);
							Chair.SetActive(true);
							Wadrobe.SetActive(true);	
						}	
						else{		
							if(Bed.active==true) {
							Sofa.SetActive(false);
							Bed.SetActive(true);
							Chair.SetActive(true);	
							Wadrobe.SetActive(false);
							}
							else{
								if(Sofa.active==true){
								Sofa.SetActive(true);
								Bed.SetActive(false);
								Chair.SetActive(true);
								Wadrobe.SetActive(false);
								}
								else{
									if(Wadrobe.active==true){
									Sofa.SetActive(false);
									Bed.SetActive(false);
									Chair.SetActive(true);
									Wadrobe.SetActive(true);
									}
									else{
										Sofa.SetActive(false);
										Bed.SetActive(false);
										Chair.SetActive(false);
										Wadrobe.SetActive(true);
		
	  								 }
								}
							}
						}
					}
				}
			}
		}
		 public void LoadWadrobe()  {
			if(Sofa.active==true && Wadrobe.active==true && Bed.active==true){
				Sofa.SetActive(true);
				Bed.SetActive(true);
				Chair.SetActive(true);
				Wadrobe.SetActive(true);
			}	
			else{
				if(Sofa.active==true && Bed.active==true){
				Sofa.SetActive(true);
				Bed.SetActive(true);
				Chair.SetActive(false);
				Wadrobe.SetActive(true);
				}
				else{
					if(Sofa.active==true&&Chair.active==true){
						Sofa.SetActive(true);
						Bed.SetActive(false);
						Chair.SetActive(true);
						Wadrobe.SetActive(true);	
					}
					else{
						if(Bed.active==true&&Wadrobe.active==true){
							Sofa.SetActive(false);
							Bed.SetActive(true);
							Chair.SetActive(true);
							Wadrobe.SetActive(true);	
						}						
						else{
							if(Sofa.active==true){
							Sofa.SetActive(true);
							Bed.SetActive(false);
							Chair.SetActive(false);
							Wadrobe.SetActive(true);
							}
							else{
								if(Chair.active==true){
								Sofa.SetActive(false);
								Bed.SetActive(false);
								Chair.SetActive(true);
								Wadrobe.SetActive(true);
								}	
								else{		
									if(Bed.active==true) {
										Sofa.SetActive(false);
										Bed.SetActive(true);
										Chair.SetActive(false);	
										Wadrobe.SetActive(true);
									}
			
									else{

										Sofa.SetActive(false);
										Bed.SetActive(false);
										Chair.SetActive(true);
										Wadrobe.SetActive(false);
		
	  								 }
								}
							}
						}
					}
				}
			}
		}

}
			
					
						
									
				
									