Shader "Anamorph" {
  Properties {
  	 _Color ("Main Color", Color) = (1,1,1,1)  	
     _MainTex ("Texture", 2D) = "" { TexGen ObjectLinear   }

     

  }
  Subshader {
    
        ZWrite on
        Fog { Color (0, 0, 0) }
        Cull off
        Color [_Color]
        ColorMask RGB
        
        Blend OneMinusSrcAlpha SrcAlpha
 
		Offset -1, -1
		
		Pass {
        SetTexture [_MainTex] {
		   combine texture * primary, ONE - texture
           Matrix [_Projector]
        }
     }
  }
}