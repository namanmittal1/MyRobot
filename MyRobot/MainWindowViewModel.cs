using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRobot.DataModels;

namespace MyRobot
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
       
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(String property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public RelayCommand MoveForwardCommand { get; set; }
        public RelayCommand MoveBackwardCommand { get; set; }

        public RelayCommand MultiplyCommand { get; set; }
        
        private ObservableCollection<Robot> robots;
        public ObservableCollection<Robot> Robots 
        {
            get 
            {
                return robots; 
            } 
            set
            {
                robots = value;
                RaisePropertyChanged("Robots");
            }
        }

        private Double canvasWidth;
        public Double CanvasWidth
        {
            get
            {
                return canvasWidth;
            }
            set
            {
                canvasWidth = value;
                RaisePropertyChanged("CanvasWidth");
            }
        }

        //private Int32 neckValue;

        //public Int32 NeckValue
        //{
        //    get
        //    {
        //        return neckValue;
        //    }
        //    set
        //    {
        //        neckValue = value;
        //        RaisePropertyChanged("NeckValue");
        //    }
        //}
        public MainWindowViewModel()
        {
            MoveForwardCommand = new RelayCommand(ExecuteMoveForwardCommand);
            MoveBackwardCommand = new RelayCommand(ExecuteMoveBackwardCommand);
            MultiplyCommand = new RelayCommand(ExecuteMultiplyCommand);
            Robots = new ObservableCollection<Robot>();
            Robots.Add(new Robot());
            CanvasWidth = Robots.LastOrDefault().RobotRightHand.EndX;
           // NeckValue = 1;
        }

        private void ExecuteMultiplyCommand(object obj)
        {
            if (Robots != null && Robots.Count != 0)
            {
                Robot robo = Robots.LastOrDefault();
                Robots.Add(new Robot(robo, 300));
            }
            CanvasWidth = Robots.LastOrDefault().RobotRightHand.EndX;
        }

        private void ExecuteMoveBackwardCommand(object obj)
        {
            if (Robots != null && Robots.Count != 0)
            {
                ObservableCollection<Robot> tempRobots = new ObservableCollection<Robot>(Robots);
                Robots.Clear();
                foreach (Robot r in tempRobots)
                {
                    Robots.Add(new Robot(r, -300));
                }            
            }
            CanvasWidth = Robots.LastOrDefault().RobotRightHand.EndX;
           // NeckValue = 2;
        }

        private void ExecuteMoveForwardCommand(object obj)
        {
            if (Robots != null && Robots.Count != 0)
            {
                ObservableCollection<Robot> tempRobots = new ObservableCollection<Robot>(Robots);
                Robots.Clear();
                foreach (Robot r in tempRobots)
                {
                    Robots.Add(new Robot(r, 300));
                }           
            }
            CanvasWidth = Robots.LastOrDefault().RobotRightHand.EndX;
           // NeckValue = 1;
        }
    }
}
