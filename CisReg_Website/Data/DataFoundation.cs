﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CisReg_Website.Data
{   
    /// <summary>
    /// Classe abstrata para centralizar os tipos de dados
    /// </summary>
    public abstract class DataFoundation
    {

        // Propriedade representando o indice no banco
        [BsonRepresentation(BsonType.Int32)]
        private int Id { get; set; }

    }
}
