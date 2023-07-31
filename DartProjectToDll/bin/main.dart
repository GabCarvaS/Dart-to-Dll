import 'dart:io';

int square(int x) {
  return x * x;
}

int subtract(int a, int b) {
  return a - b;
}

int main(List<String> arguments) {
  int res = square(3);
  print('res = $res');

  sleep(Duration(seconds: 2));
  return res;
}