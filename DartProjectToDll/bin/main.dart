import 'dart:io';

int multiply(int a, int b) {
  return a * b;
}

void main(List<String> arguments) {
  int res = 0;
  if (arguments.length > 0) {

    // Convert the arguments to integers with a default value of 0 if parsing fails
    int num1 = int.tryParse(arguments[0]) ?? 0;
    int num2 = int.tryParse(arguments[1]) ?? 0;

    res = multiply(num1, num2);

    if (num1 == null || num2 == null) {
      return;
    }
  }
  exit(res);
}