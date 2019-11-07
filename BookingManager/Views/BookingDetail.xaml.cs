﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookingManager.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BookingDetail : ContentPage
	{
        SQLiteAsyncConnection connection;
        List<Booking> bookingList;
        Booking _selectedbooking;
        public BookingDetail (Booking booking)
		{
			InitializeComponent ();
            connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            _selectedbooking = booking;
            GetData(booking);
        }

        private async void GetData(Booking booking)
        {
            Name.Text = booking.Name;
            PhoneNo.Text = booking.PhoneNo;
            CheckInDate.Date = booking.CheckinDate;
            CheckOutDate.Date = booking.CheckoutDate;
            TotalBookingCost.Text = booking.BookingCost;
            AdvanceAmount.Text = booking.AdvanceAmount;
            PaymentMode.Text = booking.PaymentMode;
        }
	}
}