
using System;
using Microsoft.Maui.Controls;
using System.Text.RegularExpressions;

namespace MauiPhone;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnDial(object sender, EventArgs e)
	{
		try
		{
			string phonenumber = PhoneNum.Text.Trim();
			string phonepattern = @"^\d{11}$";

			if (Regex.IsMatch(phonenumber, phonepattern))
			{
				PhoneDialer.Open(phonenumber);
			}
			else
			{
				await DisplayAlert("Invalid Input", "please enter valid number", "ok");
			}
		}
		catch(Exception ex)
		{
			await DisplayAlert("Error", ex.Message, "ok");

		}
		
	}
}

