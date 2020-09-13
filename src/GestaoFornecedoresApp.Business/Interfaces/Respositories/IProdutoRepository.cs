﻿using GestaoFornecedoresApp.Business.Interfaces.Respositories;
using GestaoFornecedoresApp.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFornecedoresApp.Business.Interfaces.Respositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedores(Guid idFornecedor);
        Task<IEnumerable<Produto>> ObterProdutosForncedores();
        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}
