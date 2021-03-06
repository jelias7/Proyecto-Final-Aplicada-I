﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicadaProyectoFinal.DAL;
using AplicadaProyectoFinal.Entidades;
using System.Data.Entity;
using System.Linq.Expressions;

namespace AplicadaProyectoFinal.BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuarios) {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.User.Add(usuarios) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Usuarios usuarios) {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(usuarios).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id) {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.User.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Usuarios Buscar(int id)
        {
            Contexto db = new Contexto();
            Usuarios usuarios = new Usuarios();

            try
            {
                usuarios = db.User.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return usuarios;
        }

        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> usuarios)
        {
            List<Usuarios> Lista = new List<Usuarios>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.User.Where(usuarios).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}
