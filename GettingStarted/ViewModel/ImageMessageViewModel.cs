using Syncfusion.XForms.Chat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace GettingStarted
{
    public class ImageMessageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<object> messages;

        /// <summary>
        /// current user of chat.
        /// </summary>
        private Author currentUser;

        public ImageMessageViewModel()
        {
            this.messages = new ObservableCollection<object>();
            this.currentUser = new Author() { Name = "Nancy", Avatar = "People_Circle16.png" };
            this.GenerateMessages();
        }

        /// <summary>
        /// Gets or sets the group message conversation.
        /// </summary>
        public ObservableCollection<object> Messages
        {
            get
            {
                return this.messages;
            }

            set
            {
                this.messages = value;
            }
        }

        /// <summary>
        /// Gets or sets the current author.
        /// </summary>
        public Author CurrentUser
        {
            get
            {
                return this.currentUser;
            }
            set
            {
                this.currentUser = value;
                RaisePropertyChanged("CurrentUser");
            }
        }

        private void GenerateMessages()
        {
            this.Messages.Add(new ImageMessage()
            {
                Source = "resource://GettingStarted.bird.gif",
                Author = new Author() { Name = "Andrea", Avatar = "People_Circle2.png" },
            });

            this.Messages.Add(new ImageMessage()
            {
                Source = "Image1.jpg",
                Author = new Author() { Name = "Andrea", Avatar = "People_Circle2.png" },
            });

            this.Messages.Add(new ImageMessage()
            {
                Source = "resource://GettingStarted.bird.gif",
                Author = new Author() { Name = "Andrea", Avatar = "People_Circle2.png" },
            });


            this.Messages.Add(new ImageMessage()
            {
                Source = "Image3.jpg",
                Author = CurrentUser,
            });

            this.Messages.Add(new ImageMessage()
            {
                Source = "resource://GettingStarted.bird.gif",
                Author = CurrentUser,
            });

            this.Messages.Add(new ImageMessage()
            {
                Source = "Image3.jpg",
                Author = CurrentUser,
            });


            this.Messages.Add(new ImageMessage()
            {
                Text = "Hi",
                Source = "Image1.jpg",
                Author = new Author() { Name = "Andrea", Avatar = "People_Circle2.png" },
            });

            this.Messages.Add(new ImageMessage()
            {
                Text = "Hi",
                Source = "resource://GettingStarted.bird.gif",
                Author = new Author() { Name = "Andrea", Avatar = "People_Circle2.png" },
            });

            this.Messages.Add(new ImageMessage()
            {
                Text = "Hi",
                Source = "Image1.jpg",
                Author = new Author() { Name = "Andrea", Avatar = "People_Circle2.png" },
            });

            this.Messages.Add(new ImageMessage()
            {
                Text = "Hi",
                Source = "resource://GettingStarted.bird.gif",
                Author = CurrentUser,
            });

            this.Messages.Add(new ImageMessage()
            {
                Text = "Hi",
                Source = "Image3.jpg",
                Author = CurrentUser,
            });

            this.Messages.Add(new ImageMessage()
            {
                Text = "Hi",
                Source = "Image3.jpg",
                Author = this.CurrentUser,
            });
        }

        /// <summary>
        /// Property changed handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Occurs when property is changed.
        /// </summary>
        /// <param name="propName">changed property name</param>
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
