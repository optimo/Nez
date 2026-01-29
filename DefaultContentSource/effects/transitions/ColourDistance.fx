// Author: P-Seebauer
// License: MIT
// ported by gre from https://gist.github.com/P-Seebauer/2a5fa2f77c883dd661f9

// https://gl-transitions.com/editor/ColourDistance
// https://github.com/gl-transitions/gl-transitions/blob/master/transitions/ColourDistance.glsl

// Converted to HLSL/XNA for Nez

sampler s0;

float _progress; // 0

float _power; // = 5.0

float4 mainPS(float2 uv : TEXCOORD0) : COLOR0
{
	float4 color = tex2D(s0, uv);
	float m = step(distance(color, 0), _progress);
	return lerp(lerp(color, 0, m), 0, pow(_progress, _power));
}

technique ColourDistance
{
	pass P0
	{
		PixelShader = compile ps_2_0 mainPS();
	}
}
