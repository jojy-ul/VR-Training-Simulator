Shader "UI/RoundedCorners"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _CornerRadius ("Corner Radius", Float) = 0.0
    }

    SubShader
    {
        Tags { "Queue"="Overlay" "IgnoreProjector"="True" "RenderType"="Transparent" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata_t
            {
                float4 vertex : POSITION;
                float2 texcoord : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            float _CornerRadius;

            v2f vert(appdata_t v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.texcoord, _MainTex);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                float2 uv = i.uv;

                // Centered coordinate
                float2 dist = abs(uv - 0.5f);
                float corner = 0.5f - _CornerRadius / 100.0f;

                // Transparent outside the rounded corners
                if (dist.x > corner || dist.y > corner)
                {
                    return fixed4(0, 0, 0, 0);
                }

                return tex2D(_MainTex, i.uv);
            }
            ENDCG
        }
    }
}
