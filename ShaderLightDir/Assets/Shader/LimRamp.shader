Shader "Custom/LimRamp"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Ramp

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
            float3 worldNormal;
            float3 viewDir;
        };

        fixed4 _Color;
        sampler2D _RampTex;

        // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
        // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
        // #pragma instancing_options assumeuniformscaling
        UNITY_INSTANCING_BUFFER_START(Props)
            // put more per-instance properties here
        UNITY_INSTANCING_BUFFER_END(Props)

        half4 LightingRamp(SurfaceOutput s, half3 lightDir, half atten)
        {
            half NdotL = dot(s.Normal, lightDir);
            half d = NdotL * 0.5 + 0.5;
            half3 ramp = tex2D(_RampTex, fixed2(d, 0.5)).rgb;
            half4 c;

            c.rgb = s.Albedo * _LightColor0.rgb * ramp;
            c.a = 0;
            return c;
        }

        void surf(Input IN, inout SurfaceOutput o)
        {
            fixed4 rimColor = fixed4(0.5, 0.7, 0.5, 1);

            // Albedo comes from a texture tinted by color
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;

            float rim = 1 - saturate(dot(IN.viewDir, o.Normal));

            o.Albedo = c.rgb;
            o.Alpha = c.a;
            o.Emission = rimColor * pow(rim, 2.5);
        }
        ENDCG
    }
    FallBack "Diffuse"
}
