﻿
using PrimerParcial.DAL;
using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace PrimerParcial.BLL
{
    public class VendedoresBll
    {
        public static object Vendedores { get; private set; }

        public static bool Guardar(Vendedores vendedor)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Vendedores.Add(vendedor) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }

                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar (Vendedores Vendedor)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(Vendedor).State = EntityState.Modified;
                if(contexto.SaveChanges()>0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Vendedores vendedor = contexto.Vendedores.Find(id);

                contexto.Vendedores.Remove(vendedor);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static Vendedores  Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Vendedores vendedor = new Vendedores();
            try
            {
               Vendedores  = contexto.Vendedores.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return vendedor;
        }

        public static List<Vendedores> GetList(Expression<Func<Vendedores, bool>> expression )
        {
            List<Vendedores> vendedores = new List<Vendedores>();
            Contexto contexto = new Contexto();
            try
            {
               Vendedores = contexto.Vendedores.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return vendedores;
        }
       
    }      

}
