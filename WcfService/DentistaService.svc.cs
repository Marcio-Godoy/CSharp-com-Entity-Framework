﻿using Controllers.Repositorios;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Tables;

namespace WcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class DentistaService : IDentista
    {
        private DentistaRepositorio Rep = new DentistaRepositorio();
        public void Cadastrar(Dentista obj)
        {
            Rep.Cadastrar(obj);
        }
        public Dentista Buscar(int ID)
        {
           return Rep.Buscar(ID);
        }
        public List<Dentista> Listar()
        {
            return Rep.Listar();
        }
        public void Deletar(int ID)
        {
            Rep.Deletar(ID);
        }
        public void Editar(Dentista objNovo)
        {
            Rep.Editar(objNovo);
        }

    }
}
