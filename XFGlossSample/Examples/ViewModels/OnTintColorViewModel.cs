﻿namespace XFGlossSample.Examples.ViewModels
{
	public class OnTintColorViewModel : IExamplesViewModel
	{
		public string PropertyDefault
		{
			get { return "Color.Default"; }
		}

		public string[] PropertyDescription
		{
			get
			{
				return new string[]
				{
					"Specifies a numeric or named XF.Color value to apply to the track/border portion of the Switch control when the control is in the \"On\" position.",
				};
			}
		}

		public string PropertyType
		{
			get { return "Xamarin.Forms.Color"; }
		}

		public string TargetClasses
		{
			get { return "Switch, SwitchCell"; }
		}
	}
}