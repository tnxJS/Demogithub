#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    setWindowTitle("First : AnyThing");

    ballPos.setX(0);
    ballPos.setY(0);

    connect(&timer, SIGNAL(timeout()), this, SLOT(updateBall()));
    timer.start(30);

    m_isTimer = false;
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::paintEvent(QPaintEvent *event)
{
    QPainter pp(this);
    pp.setPen(Qt::black);
    pp.setBrush(Qt::yellow);
    pp.drawEllipse(ballPos.x(), ballPos.y(), 30, 40);
}

void MainWindow::updateBall()
{
    if(ballPos.x() > 500)
        ballPos.setX(0);
    else
        ballPos.setX( ballPos.x() + 10);

    repaint();
}

void MainWindow::on_btn_Timer_clicked()
{
    //Qtime
    if(m_isTimer) //타이머가 작동중이라면 타이머를 멈춘다
    {
        int nElpased = 0;
        nElpased = startTimer.msecsTo(QTime::currentTime());
        m_strTmp = QString::number(nElpased);

        ui->te_Elapsed->setText(m_strTmp);
        ui->btn_Timer->setText(tr("timer_on"));
        m_isTimer = false;

    }
    else //타이머가 멈춘 상태이면 타이머를 동작시킨다
    {
        startTimer.start();

        ui->te_Elapsed->setText(0);
        ui->btn_Timer->setText(tr("timer_off"));
        m_isTimer = true;
    }
}
