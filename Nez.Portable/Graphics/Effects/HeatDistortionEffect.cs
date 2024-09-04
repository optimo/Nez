using Microsoft.Xna.Framework.Graphics;


namespace Nez
{
	public class HeatDistortionEffect : Effect
	{
		public float DistortionFactor
		{
			get => _distortionFactor;
			set
			{
				if (_distortionFactor != value)
				{
					_distortionFactor = value;

					// if (Effect != null)
						_distortionFactorParam.SetValue(_distortionFactor);
				}
			}
		}

		public float RiseFactor
		{
			get => _riseFactor;
			set
			{
				if (_riseFactor != value)
				{
					_riseFactor = value;

					// if (Effect != null)
						_riseFactorParam.SetValue(_riseFactor);
				}
			}
		}

		public Texture2D DistortionTexture
		{
            get => Parameters["_distortionTexture"].GetValueTexture2D();
			set => Parameters["_distortionTexture"].SetValue(value);
		}

		float _distortionFactor = 0.005f;
		float _riseFactor = 0.15f;
		EffectParameter _timeParam;
		EffectParameter _distortionFactorParam;
		EffectParameter _riseFactorParam;


		public HeatDistortionEffect() : base(Core.GraphicsDevice, EffectResource.HeatDistortionBytes)
		{
			_timeParam = Parameters["_time"];
			_distortionFactorParam = Parameters["_distortionFactor"];
			_riseFactorParam = Parameters["_riseFactor"];

			_distortionFactorParam.SetValue(_distortionFactor);
			_riseFactorParam.SetValue(_riseFactor);

			DistortionTexture = Core.Content.Load<Texture2D>("nez/textures/heatDistortionNoise");
		}

	}
}