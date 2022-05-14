using SQLite;
using SrezTipoAplus.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SrezTipoAplus.Data
{
    public class ItemDb
    {
            readonly SQLiteConnection db;
            public ItemDb(string connectionString)
            {
                db = new SQLiteConnection(connectionString);
                db.CreateTable<Item>();
            }
            public IEnumerable<Item> GetItem()
            {
                return db.Table<Item>().ToList();
            }
            public Item GetItem(int id)
            {
                return db.Table<Item>()
                                    .Where(i => i.ID == id)
                                    .FirstOrDefault();
            }
            public int SaveItem(Item item)
            {
                if (item.ID != 0)
                {
                    return db.Update(item);
                }
                else
                {
                    return db.Insert(item);
                }
            }
            public int DeleteItem(int id)
            {
                return db.Delete<Item>(id);
            }
        }
    }

