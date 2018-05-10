Shader "Custom/MyShader" {
	//propriedades que sao acessadas pela inspector
	Properties
	{
		
		_MainTex("Textura", 2D) = "" //Primeira textura
		_Texture2("Textura 2", 2D) = "" //Segunda Textura
		_BumpMap("Normal map", 2D) = "bump" {} //Normal Map
		_Blend("Misturar", Range(0, 1)) = 1.0
	}
		SubShader
	{
		Tags{ "RenderType" = "Opaque" }
		CGPROGRAM
#pragma surface surf Lambert 
		struct Input
	{
		float2 uv_MainTex;
		float2 uv_Texture2;
		float2 uv_BumpMap;
	};

	sampler2D _MainTex;
	sampler2D _Texture2;
	sampler2D _BumpMap;
	float _Blend;

	void surf(Input IN, inout SurfaceOutput o)
	{
		float3 t1 = tex2D(_MainTex, IN.uv_MainTex).rgb;
		float3 t2 = tex2D(_Texture2, IN.uv_Texture2).rgb;
		o.Albedo = lerp(t1, t2, _Blend);
		o.Normal = UnpackNormal(tex2D(_BumpMap, IN.uv_BumpMap));
	}
	ENDCG
	}
		Fallback "Diffuse"
}

