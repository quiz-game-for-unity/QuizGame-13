﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Room
    {
        List<Client> clients;
        public bool isFull { get; private set; }
        public Room()
        {
            clients = new List<Client>();
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
        }
        public void RemoveClient(Client client)
        {
            clients.Remove(client);
        }
    }

