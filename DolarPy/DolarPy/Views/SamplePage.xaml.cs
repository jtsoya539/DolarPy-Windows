﻿namespace DolarPy.Views;

public partial class SamplePage : ContentPage
{
	public SamplePage(SampleViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
