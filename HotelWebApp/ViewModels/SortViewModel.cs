using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelWebApp.ViewModels
{
    public enum SortState
    {
        //CLients
        ClientsNameAsc,
        ClientsNameDesc,
        ClientPassportAsc,
        ClientPassportDesc,
        ClientNameOfRoomAsc,
        ClientNameOfRoomDesc,
        ClientListAsc,
        ClientListDesc, 
        ClientCostAsc,
        ClientCostDesc,

        //Orders
        OrdersCheckInAsc,
        OrdersCheckInDesc,
        OrdersCheckOutAsc,
        OrdersCheckOutDesc,
        OrdersEmpNameAsc,
        OrdersEmpNameDesc,
        OrdersClientAsc,
        OrdersClientDesc,
        OrdersRoomAsc,
        OrdersRoomDesc,

        //Rooms
        RoomsTypeAsc,
        RoomsTypeDesc,
        RoomsCapacityAsc,
        RoomsCapacityDesc,
        RoomsSpecificationAsc,
        RoomsSpecificationDesc,

    }

    public class SortViewModel
    {
        public SortState CurrentState { get; set; }
        //Clients
        public SortState ClientsName { get; set; }
        public SortState ClientPassport { get; set; }
        public SortState ClientNameOfRoom { get; set; }
        public SortState ClientList { get; set; }
        public SortState ClientCost { get; set; }

        //Orders

        public SortState OrdersCheckIn { get; set; }
        public SortState OrdersCheckOut { get; set; }
        public SortState OrdersEmpName { get; set; }
        public SortState OrdersClient { get; set; }
        public SortState OrdersRoom { get; set; }

        //Rooms

        public SortState RoomsType { get; set; }
        public SortState RoomsCapacity { get; set; }
        public SortState RoomsSpecification { get; set; }

        public SortViewModel(SortState state)
        {
            ClientsName = state == SortState.ClientsNameAsc ? SortState.ClientsNameDesc : SortState.ClientsNameAsc;
            ClientPassport = state == SortState.ClientPassportAsc ? SortState.ClientPassportDesc : SortState.ClientPassportAsc;
            ClientNameOfRoom = state == SortState.ClientNameOfRoomAsc ? SortState.ClientNameOfRoomDesc : SortState.ClientNameOfRoomAsc;
            ClientList = state == SortState.ClientListAsc ? SortState.ClientListDesc : SortState.ClientListAsc;
            ClientCost = state == SortState.ClientCostAsc ? SortState.ClientCostDesc : SortState.ClientCostAsc;

            OrdersCheckIn = state == SortState.OrdersCheckInAsc ? SortState.OrdersCheckInDesc : SortState.OrdersCheckInAsc;
            OrdersCheckOut = state == SortState.OrdersCheckOutAsc ? SortState.OrdersCheckOutDesc : SortState.OrdersCheckOutAsc;
            OrdersEmpName = state == SortState.OrdersEmpNameAsc ? SortState.OrdersEmpNameDesc : SortState.OrdersEmpNameAsc;
            OrdersClient = state == SortState.OrdersClientAsc ? SortState.OrdersClientDesc : SortState.OrdersClientAsc;
            OrdersRoom = state == SortState.OrdersRoomAsc ? SortState.OrdersRoomDesc : SortState.OrdersRoomAsc;


            RoomsType = state == SortState.RoomsTypeAsc ? SortState.RoomsTypeDesc : SortState.RoomsTypeAsc;
            RoomsCapacity = state == SortState.RoomsCapacityAsc ? SortState.RoomsCapacityDesc : SortState.RoomsCapacityAsc;
            RoomsSpecification = state == SortState.RoomsSpecificationAsc ? SortState.RoomsSpecificationDesc : SortState.RoomsSpecificationAsc;

            CurrentState = state;
        }
    }
}
