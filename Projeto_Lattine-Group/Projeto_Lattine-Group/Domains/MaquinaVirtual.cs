﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Projeto_Lattine_Group.Domains
{
    public partial class MaquinaVirtual
    {
        public short IdMaquinaVirtual { get; set; }
        public short? IdInfraestrutura { get; set; }
        public string NomeMaquinaVirtual { get; set; }
        public string OpcoesDisponibilidade { get; set; }
        public string SistemaOperacional { get; set; }
        public string Tamanho { get; set; }
        public string NomeAdmin { get; set; }
        public string OrigemChavePublicaSsh { get; set; }

        public virtual Infraestrutura IdInfraestruturaNavigation { get; set; }
    }
}
