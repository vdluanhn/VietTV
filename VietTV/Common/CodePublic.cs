﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietTV.Model;

namespace VietTV.Common
{
    public class CodePublic : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public static string chanelIdAdd = "#123";
        public static string groupChanelId = "channelFav";
        public static ObservableCollection<GetListChanels> groupChanels;

        public static ObservableCollection<KeyedList<string, Chanel>> getListToBiding(ObservableCollection<Chanel> lstContacts)
        {
            var groupedPlayList =
                     (from list in lstContacts
                      orderby list.groupId ascending
                      group list by list.groupName into listByGroup
                         select new KeyedList<string, Chanel>(listByGroup));
            return new ObservableCollection<KeyedList<string, Chanel>>(groupedPlayList);
        }
    }
}
