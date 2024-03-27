﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiDB.Data;

#nullable disable

namespace WebApiDB.Migrations
{
    [DbContext(typeof(RecomecarDB))]
    partial class RecomecarDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PedidoProduto", b =>
                {
                    b.Property<int>("PedidosPedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutosProductId")
                        .HasColumnType("int");

                    b.HasKey("PedidosPedidoId", "ProdutosProductId");

                    b.HasIndex("ProdutosProductId");

                    b.ToTable("PedidoProduto");
                });

            modelBuilder.Entity("PedidoServico", b =>
                {
                    b.Property<int>("PedidosPedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ServicosServicoId")
                        .HasColumnType("int");

                    b.HasKey("PedidosPedidoId", "ServicosServicoId");

                    b.HasIndex("ServicosServicoId");

                    b.ToTable("PedidoServico");
                });

            modelBuilder.Entity("WebApiDB.Models.AgendamentoServico", b =>
                {
                    b.Property<int>("AgendamentoServicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AgendamentoServicoId"));

                    b.Property<DateTime>("DataAgendamento")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServicoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("AgendamentoServicoId");

                    b.HasIndex("ServicoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("AgendamentoServicos");
                });

            modelBuilder.Entity("WebApiDB.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaID"));

                    b.Property<string>("CategoriaNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("WebApiDB.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PedidoId"));

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("datetime2");

                    b.Property<bool>("PagamentoConfirmado")
                        .HasColumnType("bit");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(5.2)");

                    b.HasKey("PedidoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("WebApiDB.Models.Produto", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int?>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("WebApiDB.Models.Servico", b =>
                {
                    b.Property<int>("ServicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServicoId"));

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoServicoId")
                        .HasColumnType("int");

                    b.HasKey("ServicoId");

                    b.HasIndex("TipoServicoId");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("WebApiDB.Models.TipoServico", b =>
                {
                    b.Property<int>("TipoServicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoServicoId"));

                    b.Property<string>("NomeTipoServico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoServicoId");

                    b.ToTable("TipoServicos");
                });

            modelBuilder.Entity("WebApiDB.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("PedidoProduto", b =>
                {
                    b.HasOne("WebApiDB.Models.Pedido", null)
                        .WithMany()
                        .HasForeignKey("PedidosPedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiDB.Models.Produto", null)
                        .WithMany()
                        .HasForeignKey("ProdutosProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PedidoServico", b =>
                {
                    b.HasOne("WebApiDB.Models.Pedido", null)
                        .WithMany()
                        .HasForeignKey("PedidosPedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiDB.Models.Servico", null)
                        .WithMany()
                        .HasForeignKey("ServicosServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiDB.Models.AgendamentoServico", b =>
                {
                    b.HasOne("WebApiDB.Models.Servico", "Servicos")
                        .WithMany()
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiDB.Models.Usuario", "Usuarios")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Servicos");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("WebApiDB.Models.Pedido", b =>
                {
                    b.HasOne("WebApiDB.Models.Usuario", "Usuario")
                        .WithMany("Pedidos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WebApiDB.Models.Produto", b =>
                {
                    b.HasOne("WebApiDB.Models.Categoria", "Categorias")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaID");

                    b.Navigation("Categorias");
                });

            modelBuilder.Entity("WebApiDB.Models.Servico", b =>
                {
                    b.HasOne("WebApiDB.Models.TipoServico", "TipoServicos")
                        .WithMany("TipoServicos")
                        .HasForeignKey("TipoServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoServicos");
                });

            modelBuilder.Entity("WebApiDB.Models.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("WebApiDB.Models.TipoServico", b =>
                {
                    b.Navigation("TipoServicos");
                });

            modelBuilder.Entity("WebApiDB.Models.Usuario", b =>
                {
                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
