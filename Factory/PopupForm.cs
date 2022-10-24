using Factory.Core;
using Factory.Core.TableDatas;
using Factory.Core.TableHeaders;

namespace Factory;

/// <summary>
/// Klasa okienka do dodania kolumny.
/// </summary>
public partial class PopupForm : Form
{
    /// <summary>
    /// Baza danych.
    /// </summary>
    Database DataBase;

    /// <summary>
    /// Inicjalizacjia klasy.
    /// </summary>
    public PopupForm()
    {
        this.DataBase = new Database();
        InitializeComponent();
        this.InitData();
    }

    /// <summary>
    /// Inicjalizacjia klasy.
    /// </summary>
    public PopupForm(Database db)
    {
        this.DataBase = db;
        InitializeComponent();
        this.InitData();
    }

    /// <summary>
    /// Zakmnięcie okienka.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Return_Click(object sender, EventArgs e)
    {
        Close();
    }

    /// <summary>
    /// Dodanie kolumny wg. zaznaczonego typu.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Add_Click(object sender, EventArgs e)
    {
        if (TypeHolder.SelectedItem != null)
        {
            this.DataBase.addCol((AbstractTableHeader)TypeHolder.SelectedItem);
            Close();
        }
    }

    /// <summary>
    /// Inicjalizacjia danych wg. zaznaczonego checkboxu.
    /// </summary>
    private void InitData()
    {
        TypeHolder.Items.AddRange(new ITableHeader[] {
                        new TableHeader("INT"),
                        new TableHeader("CHAR"),
                        new TableHeader("DOUBLE"),
                        new TableHeader("BOOL"),
                    });
    }
}