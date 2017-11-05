Shader "Custom/Lucy"
{
    Properties {
        _Color1("Base Color", Color) = (1, 1, 1, 1)
        _Color2("Dark Color", Color) = (0.4, 0.2, 0.1, 1)
        _ColorMap("Color Mix Map", 2D) = "black"{}

        _Glossiness("Smoothness", Range(0, 1)) = 0
        [Gamma] _Metallic("Metallic", Range(0, 1)) = 0

        _BumpMap("Normal Map", 2D) = "bump"{}
        _BumpScale("Scale", Float) = 1

        _OcclusionMap("Occlusion", 2D) = "white"{}
        _OcclusionStrength("Strength", Range(0, 1)) = 1
        _OcclusionContrast("Contrast", Range(0, 5)) = 1
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        CGPROGRAM

        #pragma surface surf Standard fullforwardshadows addshadow
        #pragma target 3.0

        fixed4 _Color1;
        fixed4 _Color2;
        sampler2D _ColorMap;

        half _Glossiness;
        half _Metallic;

        sampler2D _BumpMap;
        half _BumpScale;

        sampler2D _OcclusionMap;
        half _OcclusionStrength;
        half _OcclusionContrast;

        struct Input {
            float2 uv_ColorMap;
        };

        void surf(Input IN, inout SurfaceOutputStandard o)
        {
            float2 uv = IN.uv_ColorMap;

            fixed4 cm = tex2D(_ColorMap, uv);
            o.Albedo = lerp(_Color1, _Color2, cm);

            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;

            fixed4 nrm = tex2D(_BumpMap, uv);
            o.Normal = UnpackScaleNormal(nrm, _BumpScale) * float3(1, -1, 1);

            fixed occ = tex2D(_OcclusionMap, uv).g;
            occ = pow(1 - occ, _OcclusionContrast);
            o.Occlusion = 1 - _OcclusionStrength * occ;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
