Shader "Custom/vertexColor" {
	Properties{
		_Color("Color", Color) = (1,1,1,1) //cor
		_MainTex("Albedo (RGB)", 2D) = "white" {} //textura
	_Glossiness("Smoothness", Range(0,1)) = 0.5 //sombreamento
		_Metallic("Metallic", Range(0,1)) = 0.0 //nivel metalico
	}
		SubShader{
		Tags{ "RenderType" = "Opaque" }
		LOD 200

		CGPROGRAM
#pragma surface surf Standard vertex:vert fullforwardshadows
#pragma target 3.0
		struct Input {
		float2 uv_MainTex;
		float3 vertexColor; 
	};

	struct v2f {
		float4 pos : SV_POSITION;
		fixed4 color : COLOR;
	};

	void vert(inout appdata_full v, out Input o)
	{
		UNITY_INITIALIZE_OUTPUT(Input,o);
		o.vertexColor = v.color; // Cor vertex como entrada para o método surf
	}

	sampler2D _MainTex;

	half _Glossiness;
	half _Metallic;
	fixed4 _Color;

	void surf(Input IN, inout SurfaceOutputStandard o)
	{
		fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
		o.Albedo = c.rgb * IN.vertexColor; // Combina cor normal com o vertex color
										   
		o.Metallic = _Metallic;
		o.Smoothness = _Glossiness;
		o.Alpha = c.a;
	}
	ENDCG
	}
		FallBack "Diffuse"
}
	