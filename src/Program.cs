using Src.Entities;

Console.WriteLine("=== Sistema de Chat em Grupo ===\n");

// Criando usuários

var groupChat = new GroupChat();

var alice = new User("Alice");
var bob = new User("Bob");
var carlos = new User("Carlos");
var diana = new User("Diana");


Console.WriteLine("=== Usuários Entrando no Grupo ===");
groupChat.JoinGroup(alice);
groupChat.JoinGroup(bob);
groupChat.JoinGroup(carlos);
groupChat.JoinGroup(diana);

Console.WriteLine("\n=== Conversação ===");
groupChat.SendMessage(alice,"Olá, pessoal!");
groupChat.SendMessage(bob,"Oi, Alice!");
groupChat.SendMessage(carlos,"E aí!");

Console.WriteLine("\n=== Mensagem Privada ===");
alice.SendPrivateMessage(bob, "Bob, você viu o relatório?");

Console.WriteLine("\n=== Saindo do Grupo ===");
groupChat.LeaveGroup(diana);
groupChat.SendMessage(diana,"Diana saiu");

Console.WriteLine("\n=== PROBLEMAS ===");
Console.WriteLine("✗ Acoplamento alto: cada usuário conhece todos os outros");
Console.WriteLine("✗ Comunicação M×N: cada usuário envia para N-1 outros");
Console.WriteLine("✗ Lógica de notificação duplicada em cada método");
Console.WriteLine("✗ Usuários modificam estado de outros usuários diretamente");
Console.WriteLine("✗ Difícil adicionar regras centralizadas (moderação, filtros)");
Console.WriteLine("✗ Não há lugar único para implementar log de mensagens");
Console.WriteLine("✗ Difícil adicionar novos tipos de interação");
Console.WriteLine("✗ Gerenciamento de grupo espalhado entre usuários");

Console.WriteLine("\n=== Requisitos Não Atendidos ===");
Console.WriteLine("• Moderação centralizada com permissões");
Console.WriteLine("• Log centralizado de todas as mensagens");
Console.WriteLine("• Filtro de palavras proibidas");
Console.WriteLine("• Rate limiting (limite de mensagens por minuto)");
Console.WriteLine("• Histórico de mensagens");
Console.WriteLine("• Notificações inteligentes");