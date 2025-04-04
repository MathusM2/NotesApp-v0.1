﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp_v0._1.Models
{
    public class DataContacts : INotifyPropertyChanged
    {
        /*O uso de private, e para tornar as propriedades controladas, e que não sejam acessadas por outros escopos diretamente
        Assim usando get e set, get para enviar a leitura da variavel, e set para receber um alteração dessa variavel, com a possibilidade
        de adicionar verificações, ou adicionar funções, como no caso INotifyPropertryChanged
        Ao adiciona-la dentro da estrutura do Objeto DataContacts, isso garante que todo o objeto do tipo DataContacts possua a função de notificar
        Seus ouvintes ou dependentes de forma automatica, caso haja uma alteração nas suas propriedades*/
        private string DataName;
        private string DataLastName;
        private string DataNumberPhone;
        private bool DataFavorited;
        private bool DataHasNumber;
        private int DataAge;
        private string DataRelationship;
        private string DataGender;
        private string DataCommentary;

        private Adress DataAdress;

        public DataContacts(string name, string numberPhone, bool favorited, bool hasNumber, int age, string relationship, string lastName, string gender, Adress adress, string comemmtary)
        {
            DataName = name;
            DataNumberPhone = numberPhone;
            DataFavorited = favorited;
            DataHasNumber = hasNumber;
            DataAge = age;
            DataRelationship = relationship;
            DataLastName = lastName;
            DataGender = gender;
            DataAdress = adress;
            DataCommentary = comemmtary;
        }

        //Este método e responsavel de adicionar as funcionalidades de getting e setter, e tornar publico o acesso destas propriedades
        //por meio do controle get e set, a códigos externos
        public string Name
        {

            get { return DataName; }
            set
            {


                if (DataName != value)//Verificação se o valor recebido de um código externo para alteração, NÃO e igual ao DataName(Valor Atual da propriedade Name do objeto DataContacts)
                {
                    DataName = value;//DataName recebe o valor do código externo para alteração
                    NotifyPropertyChanged(nameof(Name));//Chama o método NotifyPropertyChanged e passa o Nome da propriedade alterada

                }
            }
        }

        public string LastName
        {
            get { return DataLastName; }
            set
            {
                if (DataLastName != value)
                {
                    DataLastName = value;
                }
            }
        }

        public string NumberPhone
        {
            get { return DataNumberPhone; }
            set
            {
                if (DataNumberPhone != value)
                {
                    DataNumberPhone = value;
                }
            }
        }

        public bool Favorited
        {
            get { return DataFavorited; }
            set
            {
                if (DataFavorited != value)
                {
                    DataFavorited = value;
                }
            }
        }

        public bool HasNumber
        {
            get { return DataHasNumber; }
            set
            {
                if(DataHasNumber != value)
                {
                    DataHasNumber = value;
                }
            }
        }

        public int Age
        {
            get { return DataAge; }
            set
            {
                if (DataAge != value)
                {
                    DataAge = value;
                }
            }
        }

        public string Relationship
        {
            get { return DataRelationship; }
            set
            {
                if (DataRelationship != value)
                {
                    DataRelationship = value;
                }
            }
        }

        public string Gender
        {
            get { return DataGender; }
            set
            {
                if (DataGender != value)
                {
                    DataGender = value;
                }
            }
        }

        public Adress Adress
        {
            get { return DataAdress; }
            set
            {
                if (DataAdress != value)
                {
                    DataAdress = value;
                }
            }
        }

        public string Commentary
        {
            get { return DataCommentary; }
            set
            {
                if (DataCommentary != value)
                {
                    DataCommentary = value;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;//Aqui esta sendo declarado o nome do evento responsável por delegar aos ouvintes a notificação de uma alteração na propriedade
        protected virtual void NotifyPropertyChanged(string proportyName)//Esse e o método responsável por enviar para os ouvintes qual foi a alteração, usando o nome da propriedade recebida
        {
            if (PropertyChanged != null)//Verifica se um evento foi acionado, no caso alteração na propriedade
            {
                PropertyChanged(this, new PropertyChangedEventArgs(proportyName));//Aqui e construido a mensagem de notificação, enviando "this", referenciando o codigo atual de DataContacts e "propertyName" que envia o nome da variavel alterada ao ouvinte
            }
        }


    }
}
