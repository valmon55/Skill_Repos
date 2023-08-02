﻿using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CS_Basic.Module_11_Task_2_4
{
    internal class Bot : BackgroundService
    {
        private ITelegramBotClient _telegramClient;
        public Bot(ITelegramBotClient telegramClient)
        {
            _telegramClient = telegramClient;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _telegramClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                new ReceiverOptions() { AllowedUpdates = { } }, // Здесь выбираем, какие обновления хотим получать. В данном случае разрешены все
                cancellationToken: stoppingToken);

            Console.WriteLine("Бот запущен");
        }
        async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            //  Обрабатываем нажатия на кнопки  из Telegram Bot API: https://core.telegram.org/bots/api#callbackquery

            if (update.Type == UpdateType.CallbackQuery)
            {
                await _telegramClient.SendTextMessageAsync(update.Message.Chat.Id,
                    $"Данный тип сообщений не поддерживается. Пожалуйста отправьте текст.",
                    cancellationToken: cancellationToken);
                return;
            }
            if (update.Type == UpdateType.Message)
            {
                switch (update.Message!.Type)
                {
                    case MessageType.Text:
                        Console.WriteLine($"Получено сообщение {update.Message.Text}");
                        await _telegramClient.SendTextMessageAsync(update.Message.Chat.Id,
                            $"Длина сообщения: {update.Message.Text.Length} знаков",
                            cancellationToken: cancellationToken);
                    break;
                default :
                    Console.WriteLine($"Тип сообщения {update.Message.Type.ToString()}");
                    await _telegramClient.SendTextMessageAsync(update.Message.Chat.Id,
                        $"Данный тип сообщений не поддерживается. Пожалуйста отправьте текст.", 
                        cancellationToken: cancellationToken);
                    break;
                }
            }
        }
        Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Задаем сообщение об ошибке в зависимости от того, какая именно ошибка произошла
            var errorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            // Выводим в консоль информацию об ошибке
            Console.WriteLine(errorMessage);

            // Задержка перед повторным подключением
            Console.WriteLine("Ожидаем 10 секунд перед повторным подключением.");
            Thread.Sleep(10000);

            return Task.CompletedTask;
        }
    }
}
