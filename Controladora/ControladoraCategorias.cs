using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraCategorias
    {
        private static readonly Lazy<ControladoraCategorias> instance = new Lazy<ControladoraCategorias>(() => new ControladoraCategorias());
        public static ControladoraCategorias Instance => instance.Value;

        private DBCreacion db;
        private ControladoraCategorias()
        {
            db = new DBCreacion();
        }
        public ReadOnlyCollection<Categoria> RecuperarCategorias()
        {
            try
            {
                return db.Categorias.Include(c => c.Productos).ToList().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<Categoria>(new List<Categoria>());
            }
        }


        public bool AgregarCategoria(Categoria categoria)
        {
            try
            {
                var existeCategoria = db.Categorias.FirstOrDefault(c => c.Codigo == categoria.Codigo);
                if (existeCategoria == null)
                {
                    db.Categorias.Add(categoria);
                    return db.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool ModificarCategoria(Categoria categoria)
        {
            try
            {
                var existeCategoria = db.Categorias.FirstOrDefault(c => c.Codigo == categoria.Codigo);
                if (existeCategoria != null)
                {
                    db.Categorias.Update(categoria);
                    return db.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
