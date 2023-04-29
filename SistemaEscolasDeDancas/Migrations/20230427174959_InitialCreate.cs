using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace EscolasDeDanca.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_alunos",
                columns: table => new
                {
                    id_aluno = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nome_aluno = table.Column<string>(type: "varchar(100)", nullable: true),
                    data_nascimento = table.Column<DateTime>(type: "date", nullable: false),
                    sexo = table.Column<string>(type: "varchar(30)", nullable: true),
                    cpf = table.Column<long>(type: "bigint", nullable: false),
                    endereco = table.Column<string>(type: "varchar(100)", nullable: true),
                    telefone = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", nullable: true),
                    id_escola = table.Column<int>(type: "int(11)", nullable: false),
                    id_matricula = table.Column<int>(type: "int(11)", nullable: false),
                    ativo = table.Column<ulong>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_alunos", x => x.id_aluno);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_escola",
                columns: table => new
                {
                    id_escola = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    razao_social = table.Column<string>(type: "varchar(100)", nullable: true),
                    nome_fantasia = table.Column<string>(type: "varchar(100)", nullable: true),
                    cnpj = table.Column<int>(type: "int", nullable: false),
                    endereco = table.Column<string>(type: "varchar(100)", nullable: true),
                    telefone = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", nullable: true),
                    site = table.Column<string>(type: "varchar(100)", nullable: true),
                    ativo = table.Column<ulong>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_escola", x => x.id_escola);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_modalidades",
                columns: table => new
                {
                    id_modalidade = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_escola = table.Column<int>(type: "int(11)", nullable: false),
                    nome_modalidade = table.Column<string>(type: "varchar(100)", nullable: true),
                    id_nivel = table.Column<int>(type: "int(11)", nullable: false),
                    valor = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    descricao = table.Column<string>(type: "varchar(100)", nullable: true),
                    ativo = table.Column<ulong>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_modalidades", x => x.id_modalidade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_nivel",
                columns: table => new
                {
                    id_nivel = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_escola = table.Column<int>(type: "int(11)", nullable: false),
                    nome_nivel = table.Column<string>(type: "varchar(100)", nullable: true),
                    idade_minima = table.Column<int>(type: "int(11)", nullable: false),
                    idade_maxima = table.Column<int>(type: "int(11)", nullable: false),
                    ativo = table.Column<ulong>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nivel", x => x.id_nivel);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_professores",
                columns: table => new
                {
                    id_professor = table.Column<int>(type: "Int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_escola = table.Column<int>(type: "int(11)", nullable: false),
                    nome_professor = table.Column<string>(type: "varchar(100)", nullable: true),
                    data_nascimento = table.Column<DateTime>(type: "date", nullable: false),
                    sexo = table.Column<string>(type: "varchar(30)", nullable: true),
                    cpf = table.Column<int>(type: "int", nullable: false),
                    endereco = table.Column<string>(type: "varchar(100)", nullable: true),
                    telefone = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", nullable: true),
                    ativo = table.Column<ulong>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_professores", x => x.id_professor);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_turmas",
                columns: table => new
                {
                    id_turma = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_professor = table.Column<int>(type: "int(11)", nullable: false),
                    nome_turma = table.Column<string>(type: "varchar(100)", nullable: true),
                    horario_inicial = table.Column<TimeSpan>(type: "time", nullable: false),
                    horario_final = table.Column<TimeSpan>(type: "time", nullable: false),
                    dias = table.Column<string>(type: "varchar(100)", nullable: true),
                    data_inicio = table.Column<DateTime>(type: "date", nullable: false),
                    data_fim = table.Column<DateTime>(type: "date", nullable: false),
                    id_escola = table.Column<int>(type: "int(11)", nullable: false),
                    id_modalidade = table.Column<int>(type: "int(11)", nullable: false),
                    ativo = table.Column<ulong>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_turmas", x => x.id_turma);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_alunos");

            migrationBuilder.DropTable(
                name: "tb_escola");

            migrationBuilder.DropTable(
                name: "tb_modalidades");

            migrationBuilder.DropTable(
                name: "tb_nivel");

            migrationBuilder.DropTable(
                name: "tb_professores");

            migrationBuilder.DropTable(
                name: "tb_turmas");
        }
    }
}
