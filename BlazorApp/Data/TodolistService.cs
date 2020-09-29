using BlazorApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class TodolistService
    {
        private static readonly string[] Summaries = new[]
        {
            "��������", "���������", "������ ���� ���������", "������ ���������� ������� ����������", "�������� � �����", "����������� 4 ���������", 
            "������ ������ �����������", "������� ����� �� ��������", "������ �������", "����� ����-������"
        };

        public Task<TodoList[]> GetTodoListsAsync()
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index =>
            new TodoList
            {
                IsChecked = false,
                ElementText = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());;
        }
    }
}
