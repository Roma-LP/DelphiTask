unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Math;

type
  TForm1 = class(TForm)
    Label_X: TLabel;
    Label_Y: TLabel;
    Label_Z: TLabel;
    Edit_X: TEdit;
    Edit_Y: TEdit;
    Edit_Z: TEdit;
    Label_Result: TLabel;
    Memo_Result: TMemo;
    Button: TButton;
    procedure ButtonClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.ButtonClick(Sender: TObject);

  var x,y,z:real;
      a,b,c,u: real;
begin
    x := StrToFloat(Edit_X.Text);   // Считывается значение x
// Вывод x в окно Memo_Result
  Memo_Result.Lines.Add('x = ' + Edit_X.Text);
  y := StrToFloat(Edit_Y.Text);   // Считывается значение y
// Вывод y в окно Memo_Result
  Memo_Result.Lines.Add('y = ' + Edit_Y.Text);
  z := StrToFloat(Edit_Z.Text);  // Считывается значение z
// Вывод z в окно Memo_Result
  Memo_Result.Lines.Add('z = ' + Edit_Z.Text);
// Вычисляем арифметическое выражение
  a := Power(8+Power(Abs(x-y),2)+1,1/3);   // Abs  модуль числа
  b := Sqr(x)+Sqr(y)+2;
  c := Exp(Abs(x-y))*Power((Sqr(Tan(z))+1),x);
  u:= a/b-c;
//Выводим результат в окно Memo_Result
  Memo_Result.Lines.Add('Результат := ' + FloatToStrF(u, ffFixed, 8, 3));


end;

end.
