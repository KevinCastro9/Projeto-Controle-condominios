using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bifrost_condos
{
    public class login
    {
        Conexão conexão = new Conexão();
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();


        public string mensagem = "";
        SqlDataReader dr;
        SqlDataReader dr2;

        public string envio = "";
        public string envio2 = "";

        public bool tem = false;
        public bool tem2 = false;
        public bool tem3 = false;
        public int tem4 = 0;
        public string tem5 = "";
        public string tem6 = "F";
        public bool tem7 = false;
        public string[] tem8;
        public bool tem9 = false;
        public int tem10 = 0;
        public bool tem11 = false;
        public string tem12 = "";
        public string tem13 = "";
        public string tem14 = "";
        public string tem15 = "";
        public string tem16 = "";
        public int tem17 = 0;
        public bool tem18 = false;
        public int tem19 = 0;
        public bool tem20 = false;
        public bool tem21 = false;
        public int tem22 = 0;
        public int tem23 = 0;
        public int tem24 = 0;
        public string tem25 = "";
        public bool tem26 = false;
        public bool tem27 = false;
        public string tem28 = "";
        public int tem29 = 0;
        public string tem30 = "";
        public string[] tem31 = { };
        public string[] tem32 = { };
        public int tem33 = 0;
        public bool tem34 = false;
        public bool tem35 = false;
        public string tem36 = "";
        public bool tem37 = false;
        public string tem38 = "";
        public bool tem39 = false;
        public bool tem40 = false;
        public string tem41 = "";
        public bool tem42 = false;
        public string tem43 = "";
        public int tem44 = 0;
        public bool tem45 = false;
        public string tem46 = "";
        public int tem47 = 0;
        public bool tem48 = false;
        public string tem49 = "";
        public bool logar(string login, string senha)
        {
            //Comando sql
            cmd.CommandText = "select * from USUARIOS_DESCK where LOGIN = @login and SENHA = @senha and ATIVO = 'S'";

            //parametros
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    tem = true;
                }
                //desconectar
                conexão.desconectar();


            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }


            return tem;
        }

        public bool PrimeiraAcesso()
        {

            //Comando sql
            cmd.CommandText = "Select * from PrimeiroAcesso where PrimeiroAcesso = 0";

            //parametros


            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    tem2 = true;
                }

                //desconectar
                conexão.desconectar();

            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }

            return tem2;

        }

        public bool ConfigInicial(string NomeCondominio, string EnderecoCondominio, string NumeroDeBlocos, string NumeroDeApts, string Empresa)
        {

            //Comando sql
            cmd.CommandText = "INSERT INTO ConfigInicial (NomeCondominio, EnderecoCondominio, NumeroBlocos, NumeroApts, Empresa ) VALUES ( @NomeCondominio, @EnderecoCondominio, @NumeroBlocos, @NumeroApts, @Empresa )";

            //parametros
            cmd.Parameters.AddWithValue("@NomeCondominio", NomeCondominio);
            cmd.Parameters.AddWithValue("@EnderecoCondominio", EnderecoCondominio);
            cmd.Parameters.AddWithValue("@NumeroBlocos", NumeroDeBlocos);
            cmd.Parameters.AddWithValue("@NumeroApts", NumeroDeApts);
            cmd.Parameters.AddWithValue("@Empresa", Empresa);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                //desconectar
                conexão.desconectar();

                tem3 = true;


            }
            catch (SqlException e)
            {
                tem3 = false;
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }



            return tem3;
        }
        public void excluirCargos(string departamento)
        {
            //Comando sql
            cmd.CommandText = "delete  from CargosDepartamento where Departamento = @departamento";
            //parametros
            cmd.Parameters.AddWithValue("@departamento", departamento);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();
                //desconectar
                conexão.desconectar();



            }
            catch (SqlException e)
            {

                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            return;
        }
        public void excluirDepartamento(string departamento)
        {
            //Comando sql
            cmd.CommandText = "delete  from Departamento where Nome = @departamento";
            //parametros
            cmd.Parameters.AddWithValue("@departamento", departamento);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();
                //desconectar
                conexão.desconectar();



            }
            catch (SqlException e)
            {

                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();

            return;
        }
        public int ConfigTelaDeBlocos()
        {
            //Comando sql
            cmd.CommandText = "Select * from ConfigInicial ";

            //parametros


            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                tem4 = dr.GetInt32(2);



                //desconectar
                conexão.desconectar();

            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }

            return tem4;
        }

        public string GravarNomeBloco(string nomeBlocos, int contt)
        {

            //Comando sql
            cmd.CommandText = "insert into Blocos (NomeBloco, NumeroApt) values (@nomeBloco, @numeroBloco)";
            //parametros
            cmd.Parameters.AddWithValue("@nomeBloco", nomeBlocos);
            cmd.Parameters.AddWithValue("@numeroBloco", contt);



            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();
                //desconectar
                conexão.desconectar();

                tem6 = "V";

            }
            catch (SqlException e)
            {
                tem6 = "F";
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            return tem6;
        }

        public bool cadastrarFuncionario(string CPF, string Nome, string RG, string Telefone, string HorarioEntrada, string HorarioSaida,  string Nascimento, int codCargo)
        {
            cmd.Parameters.Clear();
            dr.Close();
            //Comando sql
            cmd.CommandText = "insert into FUNCIONARIOS (CPF_FUNCIONARIO, NOME, RG, TELEFONE, HORA_ENTRADA, HORA_SAIDA, DATA_NASCIMENTO, COD_CARGO, ATIVO) values (@CPF, @Nome, @RG, @Telefone, @HorarioEntrada, @HorarioSaida, @dataNasc, @codCargo, 'S')";
            //parametros
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@RG", RG);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);
            cmd.Parameters.AddWithValue("@HorarioEntrada", HorarioEntrada);
            cmd.Parameters.AddWithValue("@HorarioSaida", HorarioSaida);
            cmd.Parameters.AddWithValue("@dataNasc", Nascimento);
            cmd.Parameters.AddWithValue("@codCargo", codCargo);


            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();
                //desconectar
                conexão.desconectar();
                tem7 = true;


            }
            catch (SqlException e)
            {
                tem7 = false;
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            return tem7;
        }
        public string[] selectCargos()
        {

            //Comando sql
            cmd.CommandText = "select * from CARGOS";
            //parametros
            //cmd.Parameters.AddWithValue("@codCargo", p);
            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                ////Executar Comando
                //dr = cmd.ExecuteReader();

                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                //  string[] values = new string[dr.FieldCount];
                tem31 = new string[dr.FieldCount];
                while (dr.Read())
                {
                    string testel = "";
                    testel = dr.GetValue(1).ToString();
                    tem31[i] = testel;
                    i++;
                    //tem31[i] = values.ToString();
                }
                dr.Read();

                try
                {
                    //  envio = dr.GetString(0);
                }
                catch
                {
                    //  envio = "";
                }

                //desconectar
                conexão.desconectar();

            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }
            cmd.Parameters.Clear();
            return tem31;
        }
        public string[] selectDepartamento()
        {
            //Comando sql
            cmd.CommandText = "Select * from DEPARTAMENTOS";
            //parametros
            //cmd.Parameters.AddWithValue("@idDepartamento", k);
            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                ////Executar Comando
                //dr = cmd.ExecuteReader();

                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                //  string[] values = new string[dr.FieldCount];
                tem32 = new string[dr.FieldCount];
                while (dr.Read())
                {
                    string testel = "";
                    testel = dr.GetValue(1).ToString();
                    tem32[i] = testel;
                    i++;
                    //tem31[i] = values.ToString();
                }
                dr.Read();

                try
                {
                    //  envio = dr.GetString(0);
                }
                catch
                {
                    //  envio = "";
                }

                //desconectar
                conexão.desconectar();

            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }
            cmd.Parameters.Clear();
            return tem32;
        }
        public int selectCodDepar(string departamento)
        {
            //Comando sql
            cmd.CommandText = "select * from DEPARTAMENTOS where NOME = @departamento";
            //parametros
            cmd.Parameters.AddWithValue("@departamento", departamento);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                try
                {
                    tem47 = dr.GetInt32(0);
                  
                }
                catch
                {
                   
                    cmd.Parameters.Clear();
                    dr.Close();
                    cmd.Cancel();
                    return tem47;
                }

            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem47;
        }
        public void cadastrarDepartamento(string Nome, string telefone)
        {
            //Comando sql
            cmd.CommandText = "insert into DEPARTAMENTOS(NOME,  TELEFONE) Values  (@Nome,  @Telefone)";
            //parametros
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Telefone", telefone);


            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();
                //desconectar
                conexão.desconectar();
                


            }
            catch (SqlException e)
            {
                
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            return;

        }
        public void updateDepart(string nome, int id, string telefone)
        {
            //Comando sql
            cmd.CommandText = "update Departamento set Nome = @Nome, idDepartamento = @id, Telefone = @Telefone where Nome = @Nome";
            //parametros
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Telefone", telefone);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();
                //desconectar
                conexão.desconectar();



            }
            catch (SqlException e)
            {

                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            return;
        }
        public int buscarCodCargos()
        {
            //Comando sql
            cmd.CommandText = "select * from PRIMEIRO_ACESSO where PRIMEIRO_ACESSO = 1";
            
            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                tem10 = dr.GetInt32(1);
            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem10;
        }
        public void updateCodCargos(int codDepartamento)
        {

            //Comando sql
            cmd.CommandText = "update PrimeiroAcesso set CodDepartamento = @codDepartamento where PrimeiroAcesso = '1'";
            //parametros
            cmd.Parameters.AddWithValue("@codDepartamento", codDepartamento);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();
                
                //desconectar
                conexão.desconectar();

                

            }
            catch (SqlException e)
            {
                
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            return;
        }
        
        public void cadastrarAvisos(string codAvisos, string tituloAviso, string dataAviso, string blocoAviso, string aviso, string assinatura)
        {
            //Comando sql
            cmd.CommandText = "insert into avisos(codAvisos, tituloAviso, dataAviso, blocoAviso, aviso, assinatura) values (@codAvisos, @tituloAviso, @dataAviso, @blocoAviso, @aviso, @assinatura)";
            //parametros
            cmd.Parameters.AddWithValue("@codAvisos", codAvisos);
            cmd.Parameters.AddWithValue("@tituloAviso", tituloAviso);
            cmd.Parameters.AddWithValue("@dataAviso", dataAviso);
            cmd.Parameters.AddWithValue("@blocoAviso", blocoAviso);
            cmd.Parameters.AddWithValue("@aviso", aviso);
            cmd.Parameters.AddWithValue("@assinatura", assinatura);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();
                //desconectar
                conexão.desconectar();



            }
            catch (SqlException e)
            {

                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            return;
        }
        public void cadastrarReuniao(string temaCentral, string topicosSecundarios, string localReuniao, string dataReuniao, string horaReuniao, string resumoReuniao)
        {
            //Comando sql
            cmd.CommandText = "insert into REUNIAO(TEMA_CENTRAL, LOCAL_REUNIAO, DATA_HORA, RESUMO_REUNIAO, HORA_REUNIAO, TOPICOSREUNIAO)values (@temaCentral, @localReuniao, @dataReuniao, @resumoReuniao, @horaReuniao, @topicosSecundarios)";
            //parametros
            cmd.Parameters.AddWithValue("@temaCentral", temaCentral);
            cmd.Parameters.AddWithValue("@topicosSecundarios", topicosSecundarios);
            cmd.Parameters.AddWithValue("@localReuniao", localReuniao);
            cmd.Parameters.AddWithValue("@dataReuniao", dataReuniao);
            cmd.Parameters.AddWithValue("@horaReuniao", horaReuniao);
            cmd.Parameters.AddWithValue("@resumoReuniao", resumoReuniao);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();
                //desconectar
                conexão.desconectar();



            }
            catch (SqlException e)
            {

                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            return;
        }
        public void consultarDepartamentos1()
        {
            //Comando sql
            cmd.CommandText = "select * from CargosDepartamento";
            

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                //desconectar
                conexão.desconectar();



            }
            catch (SqlException e)
            {

                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }

            cmd.Parameters.Clear();
            return;
        }
        public void updateNoCadastroReuniao(string codReuniao, string temaCentral, string topicosSecundarios, string localReuniao, string dataReuniao, string horaReuniao, string resumoReuniao)
        {
            //Comando sql
            cmd.CommandText = "update REUNIAO set  TEMA_CENTRAL = @temaCentral, LOCAL_REUNIAO = @localReuniao, DATA_HORA = @dataReuniao, RESUMO_REUNIAO = @resumoReuniao, HORA_REUNIAO = @horaReuniao, TOPICOSREUNIAO = @topicosSecundarios where COD_REUNIAO = @codReuniao";
            //parametros
            cmd.Parameters.AddWithValue("@codReuniao", codReuniao);

            cmd.Parameters.AddWithValue("@temaCentral", temaCentral);
            cmd.Parameters.AddWithValue("@topicosSecundarios", topicosSecundarios);
            cmd.Parameters.AddWithValue("@localReuniao", localReuniao);
            cmd.Parameters.AddWithValue("@dataReuniao", dataReuniao);
            cmd.Parameters.AddWithValue("@horaReuniao", horaReuniao);
            cmd.Parameters.AddWithValue("@resumoReuniao", resumoReuniao);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                //desconectar
                conexão.desconectar();



            }
            catch (SqlException e)
            {

                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }

            return;
        }
        public void deletarReuniao(string codReuniao)
        {
            //Comando sql
            cmd.CommandText = "delete from REUNIAO where COD_REUNIAO = @codReuniao";
            //parametros
            cmd.Parameters.AddWithValue("@codReuniao", codReuniao);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();
                //desconectar
                conexão.desconectar();



            }
            catch (SqlException e)
            {

                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            return;
        }
        public string selectBuscaUpdate()
        {
            cmd.CommandText = "select * from buscaUpdate";
            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                tem28 = dr.GetString(0);
   

                //desconectar
                conexão.desconectar();

            }
            catch (SqlException e)
            {

                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            return tem28;
        }
        public void GravarPRaupdate(string codUpdate)
        {
            
            cmd.CommandText = "update buscaUpdate set parametroBusca = @codReuniao where parametroBusca != '1k' ";
            cmd.Parameters.AddWithValue("@codReuniao", codUpdate);
            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                //desconectar
                conexão.desconectar();



            }
            catch (SqlException e)
            {

                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            return;
        }
        public int codSindico()
        {
            //Comando sql
            cmd.CommandText = "select * from CARGOS where NOME = 'Sindico'";

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                tem29 = dr.GetInt32(0);
            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem29;
        }
        public bool cargoLogado(int codSindico)
        {
            //Comando sql
            cmd.CommandText = "select * from USUARIOS_LOGADOS where COD_CARGO = @codSindico";
            cmd.Parameters.AddWithValue("@codSindico", codSindico);


            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();

                tem27 = dr.HasRows;
                
               

                //desconectar
                conexão.desconectar();

            }
            catch (SqlException e)
            {
                
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
                
            }
            cmd.Parameters.Clear();
            return tem27;
        }
        public string selectNomeLogado()
        {
            //Comando sql
            cmd.CommandText = "select * from USUARIOS_LOGADOS";
            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                tem25 = dr.GetString(2);
            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem25;
        }
        public void updateUsuarioLogado(string login, string nome, int codUsuario, int codCargo, int cod)
        {
            //Comando sql
            cmd.CommandText = "update USUARIOS_LOGADOS set LOGIN = @login, NOME = @nome, COD_USUARIO = @COD_USUARIO, COD_CARGO = @COD_CARGO where COD = @COD";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@COD_USUARIO", codUsuario);
            cmd.Parameters.AddWithValue("@COD_CARGO", codCargo);
            cmd.Parameters.AddWithValue("@COD", cod);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                //desconectar
                conexão.desconectar();



            }
            catch (SqlException e)
            {

                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }

            cmd.Parameters.Clear();
            return;
        }
        public bool selectTravaUsu(string Usuario)
        {
            //Comando sql
            cmd.CommandText = "select * from USUARIOS_DESCK where LOGIN = @Login";
            cmd.Parameters.AddWithValue("@Login", Usuario);


            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                tem26 = true;


                //desconectar
                conexão.desconectar();

            }
            catch (SqlException e)
            {
                tem26 = false;
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            
            return tem26;
        }
        public int selectUsuarioAnterior()
        {
            //Comando sql
            cmd.CommandText = "select * from USUARIOS_LOGADOS";
            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                tem22 = dr.GetInt32(0);
            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem22;

        }
        public int selectUsuarioAnterior2(string login, string senha)
        {
            //Comando sql
            cmd.CommandText = "select * from USUARIOS_DESCK WHERE LOGIN = @login and SENHA = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                tem23 = dr.GetInt32(0);
            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem23;

        }
        public int selectUsuarioAnterior3(int codUse)
        {
            //Comando sql
            cmd.CommandText = "select * from USUARIOS_DESCK WHERE COD_USUARIO = @codUse";
            cmd.Parameters.AddWithValue("@codUse", codUse);
            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                tem24 = dr.GetInt32(7);
            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem24;

        }
        public string selectUsuarioAnterior4(int codUse)
        {
            //Comando sql
            cmd.CommandText = "select * from USUARIOS_DESCK WHERE COD_USUARIO = @codUse";
            cmd.Parameters.AddWithValue("@codUse", codUse);
            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                tem30 = dr.GetString(4);
            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem30;

        }
        public void consultarDepartamentos(string @Departamento)
        {
            //Comando sql
            cmd.CommandText = "select * from CARGOS where DEPARTAMENTOS = @Departamento";
            cmd.Parameters.AddWithValue("@Departamento", Departamento);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                //desconectar
                conexão.desconectar();
                dr.Read();


            }
            catch (SqlException e)
            {

                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }

            cmd.Parameters.Clear();
            return ;
        }
        public int codCargoFunc(string cargo)
        {
            //Comando sql
            cmd.CommandText = "Select * from CARGOS where NOME = @Cargo";
            cmd.Parameters.AddWithValue("@Cargo", cargo);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                try
                {
                    tem33 = dr.GetInt32(0);
                }
                catch
                {
                    
                }
            }
            catch (SqlException e)
            {

            }

            return tem33;
        }
        public bool cadastrarCargo(string cargos, int CodDepartamento)
        {
            //Comando sql
            cmd.CommandText = "insert into CARGOS (NOME, COD_DEPARTAMENTO) values (@Cargos, @CodDepartamento)";
            //parametros
            cmd.Parameters.AddWithValue("@Cargos", cargos);
            cmd.Parameters.AddWithValue("@CodDepartamento", CodDepartamento);



            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();
                //desconectar
                conexão.desconectar();

                tem9 = true;

            }
            catch (SqlException e)
            {
                tem9 = false;
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            return tem9;
        }
        public string buscarNomeEmpresa(string CNPJ)
        {
            //Comando sql
            cmd.CommandText = "select * from Servicos where CNPJ = @CNPJ";
            //parametros
            cmd.Parameters.AddWithValue("@CNPJ", CNPJ);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                try
                {
                    tem12 = dr.GetString(0);
                }
                catch
                {
                    tem13 = "true";
                    cmd.Parameters.Clear();
                    dr.Close();
                    cmd.Cancel();
                    return tem13;

                }
            }
            catch (SqlException e)
            {
                
            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem12;
        }
        public string buscarTelefoneDaEmpresa(string CNPJ)
        {
            //Comando sql
            cmd.CommandText = "select * from Servicos where CNPJ = @CNPJ";
            //parametros
            cmd.Parameters.AddWithValue("@CNPJ", CNPJ);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                try
                {
                    tem14 = dr.GetString(7);
                }
                catch
                {
                    tem15 = "true";
                    cmd.Parameters.Clear();
                    dr.Close();
                    cmd.Cancel();
                    return tem15;
                }
            }
            catch (SqlException e)
            {
                
            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem14;
        }
        public bool cadastrarEmpresa(string CNPJ, string NOME, string AREA_ATUACAO, string RAZAO, string NOME_FANTASIA, string CEP, string ENDERECO, int NUMERO, string COMPLEMENTO, string BAIRRO, string PAIS, string EMAIL, string INSCRICAO_ESTADUAL, string INSCRICAO_MUNICIPAL, string TELEFONE)
        {
            //Comando sql
            cmd.CommandText = "insert into EMPRESA(CNPJ, NOME, AREA_ATUACAO, RAZAO, NOME_FANTASIA, CEP, ENDERECO, NUMERO, COMPLEMENTO, BAIRRO, PAIS, EMAIL, INSCRICAO_ESTADUAL, INSCRICAO_MUNICIPAL, TELEFONE, EMPRESA_ADM) values (@CNPJ, @NOME, @AREA_ATUACAO, @RAZAO, @NOME_FANTASIA, @CEP, @ENDERECO, @NUMERO, @COMPLEMENTO, @BAIRRO, @PAIS, @EMAIL, @INSCRICAO_ESTADUAL, @INSCRICAO_MUNICIPAL, @TELEFONE, 'N')";
            //parametros
            cmd.Parameters.AddWithValue("@CNPJ", CNPJ);
            cmd.Parameters.AddWithValue("@NOME", NOME);
            cmd.Parameters.AddWithValue("@AREA_ATUACAO", AREA_ATUACAO);
            cmd.Parameters.AddWithValue("@RAZAO", RAZAO);
            cmd.Parameters.AddWithValue("@NOME_FANTASIA", NOME_FANTASIA);
            cmd.Parameters.AddWithValue("@CEP", CEP);
            cmd.Parameters.AddWithValue("@ENDERECO", ENDERECO);
            cmd.Parameters.AddWithValue("@NUMERO", NUMERO);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", COMPLEMENTO);
            cmd.Parameters.AddWithValue("@BAIRRO", BAIRRO);
            cmd.Parameters.AddWithValue("@PAIS", PAIS);
            cmd.Parameters.AddWithValue("@EMAIL", EMAIL);
            cmd.Parameters.AddWithValue("@INSCRICAO_ESTADUAL", INSCRICAO_ESTADUAL);
            cmd.Parameters.AddWithValue("@INSCRICAO_MUNICIPAL", INSCRICAO_MUNICIPAL);
            cmd.Parameters.AddWithValue("@TELEFONE", TELEFONE);
           
            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();
                //desconectar
                conexão.desconectar();

                tem34 = true;

            }
            catch (SqlException e)
            {
                tem34 = false;
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem34;
        }
        public bool cadastrarServicos(string CNPJ, string NomeFuncionario, string CpfFuncionario, string MotivoFuncionario, string dataServico, string telefoneFuncionario)
        {
            //Comando sql
            cmd.CommandText = "insert into SERVICO_PREDIO(NOME_FUNCIONARIO, CPF_FUNCIONARIO, TELEFONE_FUNCIONARIO, MOTIVO_SERVICO, DATA_SERVICO, CNPJ_EMPRESA) values (@NomeFuncionario, @CpfFuncionario, @telefoneFuncionario, @MotivoFuncionario, @dataServico, @CNPJ)";
            //parametros
            cmd.Parameters.AddWithValue("@CNPJ", CNPJ);
            cmd.Parameters.AddWithValue("@NomeFuncionario", NomeFuncionario);
            cmd.Parameters.AddWithValue("@CpfFuncionario", CpfFuncionario);
            cmd.Parameters.AddWithValue("@MotivoFuncionario", MotivoFuncionario);
            cmd.Parameters.AddWithValue("@dataServico", dataServico);
            cmd.Parameters.AddWithValue("@telefoneFuncionario", telefoneFuncionario);
           

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();
                //desconectar
                conexão.desconectar();

                tem11 = true;

            }
            catch (SqlException e)
            {
                tem11 = false;
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem11;
        }
        public string selectBlocos(int NumeroApt)
        {
            //Comando sql
            cmd.CommandText = "select * from Blocos where COD_BLOCO = @NumeroApt";
            //parametros
            cmd.Parameters.AddWithValue("@NumeroApt", NumeroApt);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                try
                {
                    tem16 = dr.GetString(1);
                }
                catch
                {
                    tem16 = "";
                    cmd.Parameters.Clear();
                    dr.Close();
                    cmd.Cancel();
                    return tem16;
                }
            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem16;
        }
        
        public bool cadastrarMoradores(string Nome, string CPF, string RG, string Sexo, string dataNascimento, string Telefone, int Bloco, string Apartamento, string Interfone, string Garagem, string Email)
        {
            //Comando sql
            cmd.CommandText = "insert into MORADORES(CPF, Nome, RG, Sexo, DATA_NASCIMENTO, Telefone,  Apartamento, Interfone, Garagem, Email, COD_BLOCO, ATIVO) values (@CPF, @Nome, @RG, @Sexo, @dataNascimento, @Telefone, @Apartamento, @Interfone, @Garagem, @Email, @Bloco, 'S')";
            //parametros
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@RG", RG);
            cmd.Parameters.AddWithValue("@Sexo", Sexo);
            cmd.Parameters.AddWithValue("@dataNascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);
            cmd.Parameters.AddWithValue("@Bloco", Bloco);
            cmd.Parameters.AddWithValue("@Apartamento", Apartamento);
            cmd.Parameters.AddWithValue("@Interfone", Interfone);
            cmd.Parameters.AddWithValue("@Garagem", Garagem);
            cmd.Parameters.AddWithValue("@Email", Email);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();
                //desconectar
                conexão.desconectar();

                tem18 = true;

            }
            catch (SqlException e)
            {
                tem18 = false;
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem18;
        }
        public int selectCodCargo(string cargo)
        {
            //Comando sql
            cmd.CommandText = "select * from CARGOS where NOME = @cargo";
            //parametros
            cmd.Parameters.AddWithValue("@cargo", cargo);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                try
                {
                    tem44 = dr.GetInt32(0);
                }
                catch
                {
                    
                    cmd.Parameters.Clear();
                    dr.Close();
                    cmd.Cancel();
                    return tem44;
                }
            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem44;
        }
        public bool cadastrarUsuario(string Login, string Senha, string Nome, int Cargo, string Assinatura, string CPF_FUNCIONARIO)
        {
            //Comando sql
            cmd.CommandText = "insert into USUARIOS_DESCK (LOGIN, SENHA, ATIVO, NOME, ASSINATURA, CPF_FUNCIONARIO, COD_CARGO) values (@Login, @Senha, 'S', @Nome, @Assinatura, @CPF_FUNCIONARIO, @Cargo)";
            //parametros
            cmd.Parameters.AddWithValue("@Login", Login);
            cmd.Parameters.AddWithValue("@Senha", Senha);
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Assinatura", Assinatura);
            cmd.Parameters.AddWithValue("@CPF_FUNCIONARIO", CPF_FUNCIONARIO);
            cmd.Parameters.AddWithValue("@Cargo", Cargo);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();
                //desconectar
                conexão.desconectar();

                tem20 = true;

            }
            catch (SqlException e)
            {
                tem20 = false;
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem20;
        }
        public int selectNumeroApt()
        {
            // Comando sql
            cmd.CommandText = "select * from CONFIG_INICIAL";
            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                tem17 = dr.GetInt32(9);
            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
           return tem17;

        }
        public bool cadastrarVisitante(string NomeVisitante, string CPF, string RG, string Sexo, string DataNasc, string Telefone, int BlocoVisita, string AptVisita)
        {
            //Comando sql
            cmd.CommandText = "insert into VISITANTES(CPF, RG, SEXO, DATA_NASCIMENTO, TELEFONE, APARTAMENTO, COD_BLOCO, ATIVO, NOME_VISITANTE) values (@CPF, @RG, @Sexo, @DataNasc, @Telefone, @AptVisita, @BlocoVisita, 'S', @NomeVisitante)";
            //parametros
            cmd.Parameters.AddWithValue("@NomeVisitante", NomeVisitante);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@RG", RG);
            cmd.Parameters.AddWithValue("@Sexo", Sexo);
            cmd.Parameters.AddWithValue("@DataNasc", DataNasc);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);
            cmd.Parameters.AddWithValue("@BlocoVisita", BlocoVisita);
            cmd.Parameters.AddWithValue("@AptVisita", AptVisita);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();
                //desconectar
                conexão.desconectar();

                tem21 = true;

            }
            catch (SqlException e)
            {
                tem21 = false;
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem21;

        }
        public int selectcodbloco(string NomeBloco)
        {
            //Comando sql
            cmd.CommandText = "select * from Blocos where NOME_BLOCO = @NomeBloco";
            //parametros
            cmd.Parameters.AddWithValue("@NomeBloco", NomeBloco);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                tem19 = dr.GetInt32(0);
            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
           return tem19;
        }
        public bool selectCPFMorador(string CPFMOrador)
        {
            //Comando sql
            cmd.CommandText = "select * from MORADORES where CPF = @CPFMorador";
            //parametros
            cmd.Parameters.AddWithValue("@CPFMorador", CPFMOrador);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                try
                {
                    tem36 = dr.GetString(2);
                    tem35 = true;
                }
                catch
                {
                    tem35 = false;
                    cmd.Parameters.Clear();
                    dr.Close();
                    cmd.Cancel();
                    return tem35;
                }

            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
                
            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem35;
        }
        public bool selectCPFFuncionario(string CPFFuncionario)
        {
            //Comando sql
            cmd.CommandText = "select * from FUNCIONARIOS where CPF_FUNCIONARIO = @CPFFuncionario";
            //parametros
            cmd.Parameters.AddWithValue("@CPFFuncionario", CPFFuncionario);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                try
                {
                    tem38 = dr.GetString(2);
                    tem37 = true;
                }
                catch
                {
                    tem37 = false;
                    cmd.Parameters.Clear();
                    dr.Close();
                    cmd.Cancel();
                    return tem37;
                }

            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            return tem37;
        }
        public bool SelectCPFVISI(string CPF)
        {
            //Comando sql
            cmd.CommandText = "select * from VISITANTES where CPF = @CPF";
            //parametros
            cmd.Parameters.AddWithValue("@CPF", CPF);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                try
                {
                    tem43 = dr.GetString(2);
                    tem42 = true;
                }
                catch
                {
                    tem42 = false;
                    cmd.Parameters.Clear();
                    dr.Close();
                    cmd.Cancel();
                    return tem42;
                }

            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();


            return tem42;
        }
        public bool selectUsuario(string CPF)
        {
            //Comando sql
            cmd.CommandText = "select * from USUARIOS_DESCK where CPF_FUNCIONARIO = @CPF";
            //parametros
            cmd.Parameters.AddWithValue("@CPF", CPF);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                try
                {
                    tem46 = dr.GetString(2);
                    tem45 = true;
                }
                catch
                {
                    tem45 = false;
                    cmd.Parameters.Clear();
                    dr.Close();
                    cmd.Cancel();
                    return tem45;
                }

            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();


            return tem45;
        }
        public bool SelectCNPJ(string CNPJ)
        {
            //Comando sql
            cmd.CommandText = "select * from EMPRESA where CNPJ = @CNPJ";
            //parametros
            cmd.Parameters.AddWithValue("@CNPJ", CNPJ);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                try
                {
                    tem41 = dr.GetString(2);
                    tem40 = true;
                }
                catch
                {
                    tem40 = false;
                    cmd.Parameters.Clear();
                    dr.Close();
                    cmd.Cancel();
                    return tem40;
                }

            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();
            

            return tem40;
        }
        public bool selectCargosDep(string cargo, int codDepart)
        {
            //Comando sql
            cmd.CommandText = "select * from CARGOS where NOME = @cargo and COD_DEPARTAMENTO = @codDepart";
            //parametros
            cmd.Parameters.AddWithValue("@cargo", cargo);
            cmd.Parameters.AddWithValue("@codDepart", codDepart);

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                try
                {
                    tem49 = dr.GetString(1);
                    tem48 = true;
                }
                catch
                {
                    tem48 = false;
                    cmd.Parameters.Clear();
                    dr.Close();
                    cmd.Cancel();
                    return tem48;
                }

            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";

            }
            cmd.Parameters.Clear();
            dr.Close();
            cmd.Cancel();


            return tem48;
        }
        public bool ValidaCNPJ(string CNPJ)
        {
            // Colocar os 12 primeiros números dentro de dados inteiros
            // Calcular esses 12 números e gerar os 2 dígitos verificadores
            // Verificar se é verdadeiro ou falso o CNPJ

            try
            {
                if (!(CNPJ.Length < 18))
                {
                    int n1 = Convert.ToInt16(CNPJ.Substring(0, 1));
                    int n2 = Convert.ToInt16(CNPJ.Substring(1, 1));
                    int n3 = Convert.ToInt16(CNPJ.Substring(3, 1));
                    int n4 = Convert.ToInt16(CNPJ.Substring(4, 1));
                    int n5 = Convert.ToInt16(CNPJ.Substring(5, 1));
                    int n6 = Convert.ToInt16(CNPJ.Substring(7, 1));
                    int n7 = Convert.ToInt16(CNPJ.Substring(8, 1));
                    int n8 = Convert.ToInt16(CNPJ.Substring(9, 1));
                    int n9 = Convert.ToInt16(CNPJ.Substring(11, 1));
                    int n10 = Convert.ToInt16(CNPJ.Substring(12, 1));
                    int n11 = Convert.ToInt16(CNPJ.Substring(13, 1));
                    int n12 = Convert.ToInt16(CNPJ.Substring(14, 1));

                    int digito1 = Convert.ToInt16(CNPJ.Substring(16, 1));
                    int digito2 = Convert.ToInt16(CNPJ.Substring(17, 1));

                    if (n1 == 0 && n2 == 0 && n3 == 0 && n4 == 0 && n5 == 0 && n6 == 0 && n7 == 0 && n8 == 0 && n9 == 0 && n10 == 0 && n11 == 0 && n12 == 0 && digito1 == 0 && digito2 == 0)
                    {
                        return false;
                    }

                    int Soma1 = n1 * 5 + n2 * 4 + n3 * 3 + n4 * 2 + n5 * 9 + n6 * 8 + n7 * 7 + n8 * 6 + n9 * 5 + n10 * 4 + n11 * 3 + n12 * 2;

                    int digitoVerificador1 = Soma1 % 11;

                    if (digitoVerificador1 < 2)
                    {
                        digitoVerificador1 = 0;
                    }
                    else
                    {
                        digitoVerificador1 = 11 - digitoVerificador1;
                    }

                    int Soma2 = n1 * 6 + n2 * 5 + n3 * 4 + n4 * 3 + n5 * 2 + n6 * 9 + n7 * 8 + n8 * 7 + n9 * 6 + n10 * 5 + n11 * 4 + n12 * 3 + digitoVerificador1 * 2;

                    int digitoVerificador2 = Soma2 % 11;

                    if (digitoVerificador2 < 2)
                    {
                        digitoVerificador2 = 0;
                    }
                    else
                    {
                        digitoVerificador2 = 11 - digitoVerificador2;
                    }

                    // Verifica se CNPJ é verdadeiro ou falso
                    if (digito1 == digitoVerificador1 && digito2 == digitoVerificador2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
            catch { return false; }

        }

        public void AlterarPrimeiroAcesso()
        {
            
            try
            {
                //Comando sql
                cmd.CommandText = "update PrimeiroAcesso set PrimeiroAcesso = '1' where PrimeiroAcesso = '0'";
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();               
                //desconectar
                conexão.desconectar();

            }
            catch (SqlException e)
            {
                this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }
        }
    }
}
