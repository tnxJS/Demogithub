#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QApplication>
#include <QPainter>

#include <QPoint>
#include <QTimer>
#include <QElapsedTimer>
#include <QTime>

QT_BEGIN_NAMESPACE
namespace Ui { class MainWindow; }
QT_END_NAMESPACE

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    MainWindow(QWidget *parent = nullptr);
    ~MainWindow();
    virtual void paintEvent(QPaintEvent *event);

private slots:
    void updateBall();

    void on_btn_Timer_clicked();

private:
    Ui::MainWindow *ui;

    //위치 관련
    QPointF ballPos;

    //타이머 관련
    QTimer timer;
    QElapsedTimer qeTimer;
    QTime startTimer;
    bool m_isTimer;

    //임시변수들
    QString m_strTmp;
};
#endif // MAINWINDOW_H
