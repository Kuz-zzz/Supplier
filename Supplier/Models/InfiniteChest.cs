﻿using Auxiliary;

namespace Supplier.Models
{
    public class InfiniteChest : BsonModel
    {
        private int _index;
        public int Index
        {
            get
              => _index;
            set
            {
                _ = this.SaveAsync(x => x.Index, value);
                _index = value;
            }
        }

        private string? _world;
        public string? World
        {
            get
              => _world;
            set
            {
                _ = this.SaveAsync(x => x.World, value);
                _world = value;
            }
        }

        private List<ChestItem> _items = new List<ChestItem>();
        public List<ChestItem> Items
        {
            get
              => _items;
            set
            {
                _ = this.SaveAsync(x => x.Items, value);
                _items = value;
            }
        }

        private int _x;

        public int X
        {
            get
              => _x;
            set
            {
                _ = this.SaveAsync(x => x.X, value);
                _x = value;
            }
        }

        private int _y;
        public int Y
        {
            get
              => _y;
            set
            {
                _ = this.SaveAsync(x => x.Y, value);
                _y = value;
            }
        }

        private int delay = 0;
        public int Delay
        {
            get
              => delay;
            set
            {
                _ = this.SaveAsync(x => x.Delay, value);
                delay = value;
            }
        }

    }
}
