Shader "Custom/ztest"{
	Properties{
		_Color("Color", Color) = (0,0,0)//textura a ser usada


	}
		SubShader{
		tags{ "Queue" = "Geometry+1" }
		Pass{
		Ztest always //sempre renderizado

					 //SetTexture[_Color]
		Color[_Color]
	}

	}

}