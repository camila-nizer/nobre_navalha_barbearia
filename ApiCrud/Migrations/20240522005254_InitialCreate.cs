using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCrud.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atendimento",
                columns: table => new
                {
                    IdAtendimento = table.Column<Guid>(type: "uuid", nullable: false),
                    IdCliente = table.Column<Guid>(type: "uuid", nullable: false),
                    IdServico = table.Column<Guid>(type: "uuid", nullable: false),
                    IdPrecoServico = table.Column<Guid>(type: "uuid", nullable: false),
                    IdDesconto = table.Column<Guid>(type: "uuid", nullable: false),
                    UnidadeBarbearia = table.Column<Guid>(type: "uuid", nullable: false),
                    DataHora = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Observacoes = table.Column<string>(type: "text", nullable: false),
                    StatusAtendimento = table.Column<string>(type: "text", nullable: false),
                    TipoPagamento = table.Column<string>(type: "text", nullable: false),
                    ValorPago = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendimento", x => x.IdAtendimento);
                });

            migrationBuilder.CreateTable(
                name: "Desconto",
                columns: table => new
                {
                    IdDesconto = table.Column<Guid>(type: "uuid", nullable: false),
                    DescricaoDesconto = table.Column<string>(type: "text", nullable: false),
                    StatusDesconto = table.Column<string>(type: "text", nullable: false),
                    ValorDesconto = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desconto", x => x.IdDesconto);
                });

            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    IdEspecialidade = table.Column<Guid>(type: "uuid", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    StatusEspecialidade = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.IdEspecialidade);
                });

            migrationBuilder.CreateTable(
                name: "Fidelidade",
                columns: table => new
                {
                    IdFidelidade = table.Column<Guid>(type: "uuid", nullable: false),
                    IdCliente = table.Column<Guid>(type: "uuid", nullable: false),
                    CortesRealizados = table.Column<int>(type: "integer", nullable: false),
                    CortesGratisDisponiveis = table.Column<int>(type: "integer", nullable: false),
                    DataCortesGratis = table.Column<DateTime[]>(type: "timestamp with time zone[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fidelidade", x => x.IdFidelidade);
                });

            migrationBuilder.CreateTable(
                name: "FuncionarioEspecialidade",
                columns: table => new
                {
                    IdFuncionario = table.Column<Guid>(type: "uuid", nullable: false),
                    IdEspecialidade = table.Column<Guid>(type: "uuid", nullable: false),
                    StatusFuncEsp = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncionarioEspecialidade", x => x.IdFuncionario);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    IdPessoa = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Nascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CPF = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Sexo = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    StatusPessoa = table.Column<string>(type: "text", nullable: false),
                    UnidadeBarbearia = table.Column<Guid>(type: "uuid", nullable: false),
                    EnderecoPessoa = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    IdCliente = table.Column<Guid>(type: "uuid", nullable: true),
                    Observacoes = table.Column<string>(type: "text", nullable: true),
                    StatusCliente = table.Column<string>(type: "text", nullable: true),
                    IdFuncionario = table.Column<Guid>(type: "uuid", nullable: true),
                    StatusFuncionario = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.IdPessoa);
                });

            migrationBuilder.CreateTable(
                name: "PrecoServico",
                columns: table => new
                {
                    IdPrecoServico = table.Column<Guid>(type: "uuid", nullable: false),
                    Preco = table.Column<float>(type: "real", nullable: false),
                    StatusPrecoServico = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrecoServico", x => x.IdPrecoServico);
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    IdServico = table.Column<Guid>(type: "uuid", nullable: false),
                    NomeServico = table.Column<string>(type: "text", nullable: false),
                    Especialidade = table.Column<Guid>(type: "uuid", nullable: false),
                    StatusServico = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.IdServico);
                });

            migrationBuilder.CreateTable(
                name: "UnidadesBarbearia",
                columns: table => new
                {
                    IdUnidade = table.Column<Guid>(type: "uuid", nullable: false),
                    NomeSocial = table.Column<string>(type: "text", nullable: false),
                    CNPJ = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    DataAbertura = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    StatusUnidade = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadesBarbearia", x => x.IdUnidade);
                });

            migrationBuilder.CreateTable(
                name: "UnidadeServico",
                columns: table => new
                {
                    IdUnidadeServico = table.Column<Guid>(type: "uuid", nullable: false),
                    IdServico = table.Column<Guid>(type: "uuid", nullable: false),
                    StatusUnidadeServico = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeServico", x => x.IdUnidadeServico);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Rua = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    Complemento = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    CEP = table.Column<string>(type: "text", nullable: false),
                    PessoaIdPessoa = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Endereco_Pessoas_PessoaIdPessoa",
                        column: x => x.PessoaIdPessoa,
                        principalTable: "Pessoas",
                        principalColumn: "IdPessoa");
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    StatusItem = table.Column<bool>(type: "boolean", nullable: false),
                    StatusDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ClienteIdPessoa = table.Column<Guid>(type: "uuid", nullable: true),
                    FuncionarioIdPessoa = table.Column<Guid>(type: "uuid", nullable: true),
                    PessoaIdPessoa = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Status_Pessoas_ClienteIdPessoa",
                        column: x => x.ClienteIdPessoa,
                        principalTable: "Pessoas",
                        principalColumn: "IdPessoa");
                    table.ForeignKey(
                        name: "FK_Status_Pessoas_FuncionarioIdPessoa",
                        column: x => x.FuncionarioIdPessoa,
                        principalTable: "Pessoas",
                        principalColumn: "IdPessoa");
                    table.ForeignKey(
                        name: "FK_Status_Pessoas_PessoaIdPessoa",
                        column: x => x.PessoaIdPessoa,
                        principalTable: "Pessoas",
                        principalColumn: "IdPessoa");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_PessoaIdPessoa",
                table: "Endereco",
                column: "PessoaIdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Status_ClienteIdPessoa",
                table: "Status",
                column: "ClienteIdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Status_FuncionarioIdPessoa",
                table: "Status",
                column: "FuncionarioIdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Status_PessoaIdPessoa",
                table: "Status",
                column: "PessoaIdPessoa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atendimento");

            migrationBuilder.DropTable(
                name: "Desconto");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Especialidade");

            migrationBuilder.DropTable(
                name: "Fidelidade");

            migrationBuilder.DropTable(
                name: "FuncionarioEspecialidade");

            migrationBuilder.DropTable(
                name: "PrecoServico");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "UnidadesBarbearia");

            migrationBuilder.DropTable(
                name: "UnidadeServico");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
