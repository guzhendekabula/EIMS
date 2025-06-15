/*
 Navicat Premium Data Transfer

 Source Server         : localhost_3306
 Source Server Type    : MySQL
 Source Server Version : 80018
 Source Host           : localhost:3306
 Source Schema         : eims_22318017

 Target Server Type    : MySQL
 Target Server Version : 80018
 File Encoding         : 65001

 Date: 15/01/2025 23:14:48
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for customer
-- ----------------------------
DROP TABLE IF EXISTS `customer`;
CREATE TABLE `customer`  (
  `CustomerID` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Company` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Sex` varchar(2) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Age` int(11) NULL DEFAULT NULL,
  `Telephone` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Address` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`CustomerID`) USING BTREE,
  INDEX `idx_customer_name`(`CustomerName` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 15 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of customer
-- ----------------------------
INSERT INTO `customer` VALUES (1, '张三', '蓝国科技', '男', 28, '13800138000', '蓝国蓝海市蓝波路3号');
INSERT INTO `customer` VALUES (2, '李四', '绿岛国贸易', '女', 34, '13900139000', '绿岛国绿岛市绿波路4号');
INSERT INTO `customer` VALUES (3, '王五', '红海集团', '男', 45, '13700137000', '红海国红海市红波路5号');
INSERT INTO `customer` VALUES (4, '赵六', '黄石矿业', '女', 52, '13600136000', '黄石国黄石市黄波路6号');
INSERT INTO `customer` VALUES (5, '孙七', '黑水能源', '男', 38, '13500135000', '黑水国黑水市黑波路7号');
INSERT INTO `customer` VALUES (6, '周八', '白山旅游', '女', 24, '13400134000', '白山国白山市白波路8号');
INSERT INTO `customer` VALUES (7, '吴九', '金石建筑', '男', 41, '13300133000', '金石国金石市金波路9号');
INSERT INTO `customer` VALUES (8, '郑十', '银月电子', '女', 29, '13200132000', '银月国银月市银波路10号');
INSERT INTO `customer` VALUES (9, '王十一', '青铜文化', '男', 55, '13100131000', '青铜国青铜市青波路11号');
INSERT INTO `customer` VALUES (10, '李十二', '紫光软件', '女', 22, '13000130000', '紫光国紫光市紫波路12号');
INSERT INTO `customer` VALUES (11, '卡布拉', '不知道', '男', 3, '6213', '中山一路');

-- ----------------------------
-- Table structure for department
-- ----------------------------
DROP TABLE IF EXISTS `department`;
CREATE TABLE `department`  (
  `dept_no` int(11) NOT NULL,
  `dept_name` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `dept_peoplecount` int(11) NULL DEFAULT 0,
  PRIMARY KEY (`dept_no`) USING BTREE,
  INDEX `idx_department_name`(`dept_name` ASC) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of department
-- ----------------------------
INSERT INTO `department` VALUES (1, '管理部', 3);
INSERT INTO `department` VALUES (2, '技术部', 1);
INSERT INTO `department` VALUES (3, '销售部', 2);
INSERT INTO `department` VALUES (4, '研发部', 1);
INSERT INTO `department` VALUES (5, '算法部', 3);
INSERT INTO `department` VALUES (6, '行政部', 2);
INSERT INTO `department` VALUES (7, '人事部', 2);
INSERT INTO `department` VALUES (8, '安全部', 3);
INSERT INTO `department` VALUES (10, '哈哈部', 0);

-- ----------------------------
-- Table structure for employee
-- ----------------------------
DROP TABLE IF EXISTS `employee`;
CREATE TABLE `employee`  (
  `emp_no` int(11) NOT NULL,
  `first_name` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `last_name` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `gender` int(11) NULL DEFAULT NULL,
  `hire_date` datetime NULL DEFAULT NULL,
  `birthday` datetime NULL DEFAULT NULL,
  `address` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `telephone` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`emp_no`) USING BTREE,
  INDEX `idx_employee_name`(`last_name` ASC, `first_name` ASC) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of employee
-- ----------------------------
INSERT INTO `employee` VALUES (1, '邝', '柏霖', 1, '2022-11-11 00:00:00', '2003-10-01 00:00:00', NULL, NULL, '333');
INSERT INTO `employee` VALUES (2, '卡卡', '布', 0, '2025-01-09 00:00:00', '2003-01-15 00:00:00', '11', '11', '11');
INSERT INTO `employee` VALUES (3, '张', '三', 1, '2022-01-01 08:00:00', '1990-05-20 09:00:00', '北京市朝阳区', '12345678903', '1');
INSERT INTO `employee` VALUES (4, '李', '四', 0, '2022-02-01 09:00:00', '1991-06-21 10:00:00', '上海市浦东新区', '12345678904', '2');
INSERT INTO `employee` VALUES (5, '王', '五', 1, '2022-03-01 10:00:00', '1992-07-22 11:00:00', '广州市天河区', '12345678905', '3');
INSERT INTO `employee` VALUES (6, '赵', '六', 0, '2022-04-01 11:00:00', '1993-08-23 12:00:00', '深圳市南山区', '12345678906', '4');
INSERT INTO `employee` VALUES (7, '钱', '七', 1, '2022-05-01 12:00:00', '1994-09-24 13:00:00', '杭州市西湖区', '12345678907', '5');
INSERT INTO `employee` VALUES (8, '孙', '八', 0, '2022-06-01 13:00:00', '1995-10-25 14:00:00', '南京市玄武区', '12345678908', '6');
INSERT INTO `employee` VALUES (9, '周', '九', 1, '2022-07-01 14:00:00', '1996-11-26 15:00:00', '武汉市武昌区', '12345678909', '7');
INSERT INTO `employee` VALUES (10, '吴', '十', 0, '2022-08-01 15:00:00', '1997-12-27 16:00:00', '成都市青羊区', '12345678910', '8');
INSERT INTO `employee` VALUES (11, '郑', '十一', 1, '2022-09-01 16:00:00', '1998-01-28 17:00:00', '西安市雁塔区', '12345678911', '9');
INSERT INTO `employee` VALUES (12, '王', '十二', 1, '2022-10-01 00:00:00', '1999-02-28 00:00:00', '重庆市渝中区', '12345678912', '10');

-- ----------------------------
-- Table structure for employee_department
-- ----------------------------
DROP TABLE IF EXISTS `employee_department`;
CREATE TABLE `employee_department`  (
  `ed_id` int(11) NOT NULL AUTO_INCREMENT,
  `emp_no` int(11) NULL DEFAULT NULL,
  `dept_no` int(11) NULL DEFAULT NULL,
  `Ed_entrydate` datetime NULL DEFAULT NULL,
  `Ed_leavedate` datetime NULL DEFAULT NULL,
  `Ed_Status` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`ed_id`) USING BTREE,
  INDEX `dept_no`(`dept_no` ASC) USING BTREE,
  INDEX `idx_emp_dept`(`emp_no` ASC, `dept_no` ASC) USING BTREE,
  INDEX `idx_emp`(`emp_no` ASC) USING BTREE,
  CONSTRAINT `employee_department_ibfk_1` FOREIGN KEY (`emp_no`) REFERENCES `employee` (`emp_no`) ON DELETE CASCADE ON UPDATE RESTRICT,
  CONSTRAINT `employee_department_ibfk_2` FOREIGN KEY (`dept_no`) REFERENCES `department` (`dept_no`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 21 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of employee_department
-- ----------------------------
INSERT INTO `employee_department` VALUES (1, 1, 1, '2022-11-11 00:00:00', '2025-01-17 20:46:18', 1);
INSERT INTO `employee_department` VALUES (3, 2, 4, '2025-01-09 00:00:00', '2099-12-31 00:00:00', 2);
INSERT INTO `employee_department` VALUES (4, 1, 5, '2022-11-11 00:00:00', '2099-12-31 00:00:00', 1);
INSERT INTO `employee_department` VALUES (5, 2, 3, '2025-01-09 00:00:00', '2099-12-31 00:00:00', 1);
INSERT INTO `employee_department` VALUES (6, 3, 1, '2022-01-01 00:00:00', '2099-12-31 00:00:00', 1);
INSERT INTO `employee_department` VALUES (7, 4, 6, '2022-02-11 00:00:00', '2099-12-31 00:00:00', 1);
INSERT INTO `employee_department` VALUES (8, 5, 5, '2022-03-01 00:00:00', '2099-12-31 00:00:00', 1);
INSERT INTO `employee_department` VALUES (9, 6, 8, '2022-04-01 00:00:00', '2099-12-31 00:00:00', 1);
INSERT INTO `employee_department` VALUES (10, 6, 7, '2022-04-01 00:00:00', '2099-12-31 00:00:00', 1);
INSERT INTO `employee_department` VALUES (11, 10, 3, '2022-08-01 00:00:00', '2099-12-31 00:00:00', 1);
INSERT INTO `employee_department` VALUES (12, 5, 7, '2022-03-01 00:00:00', '2099-12-31 00:00:00', 1);
INSERT INTO `employee_department` VALUES (13, 11, 8, '2022-09-01 00:00:00', '2099-12-31 00:00:00', 1);
INSERT INTO `employee_department` VALUES (14, 7, 2, '2022-05-01 00:00:00', '2099-12-31 00:00:00', 1);
INSERT INTO `employee_department` VALUES (15, 5, 1, '2022-03-01 00:00:00', '2099-12-31 00:00:00', 1);
INSERT INTO `employee_department` VALUES (16, 8, 8, '2022-06-01 00:00:00', '2099-12-31 00:00:00', 1);
INSERT INTO `employee_department` VALUES (17, 9, 4, '2022-07-01 00:00:00', '2099-12-31 00:00:00', 1);
INSERT INTO `employee_department` VALUES (18, 12, 5, '2022-10-01 00:00:00', '2099-12-31 00:00:00', 1);
INSERT INTO `employee_department` VALUES (21, 12, 6, '2022-10-01 00:00:00', '2099-12-31 00:00:00', 1);
INSERT INTO `employee_department` VALUES (22, 1, 10, '2022-11-11 00:00:00', '2099-12-31 00:00:00', 2);

-- ----------------------------
-- Procedure structure for GetEmployeeDepartmentCount
-- ----------------------------
DROP PROCEDURE IF EXISTS `GetEmployeeDepartmentCount`;
delimiter ;;
CREATE PROCEDURE `GetEmployeeDepartmentCount`(IN emp_id INT)
BEGIN
    SELECT COUNT(dept_no) AS department_count
    FROM Employee_Department
    WHERE emp_no = emp_id AND Ed_Status = 1;
END
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table employee_department
-- ----------------------------
DROP TRIGGER IF EXISTS `update_dept_peoplecount`;
delimiter ;;
CREATE TRIGGER `update_dept_peoplecount` AFTER INSERT ON `employee_department` FOR EACH ROW BEGIN
    IF NEW.Ed_Status = 1 THEN
        UPDATE Department
        SET dept_peoplecount = dept_peoplecount + 1
        WHERE dept_no = NEW.dept_no;
    ELSEIF NEW.Ed_Status = 2 THEN
        UPDATE Department
        SET dept_peoplecount = dept_peoplecount - 1
        WHERE dept_no = NEW.dept_no;
    END IF;
END
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table employee_department
-- ----------------------------
DROP TRIGGER IF EXISTS `update_dept_peoplecount_after_update`;
delimiter ;;
CREATE TRIGGER `update_dept_peoplecount_after_update` AFTER UPDATE ON `employee_department` FOR EACH ROW BEGIN
    IF OLD.Ed_Status = 1 AND NEW.Ed_Status != 1 THEN
        UPDATE Department
        SET dept_peoplecount = dept_peoplecount - 1
        WHERE dept_no = OLD.dept_no;
    ELSEIF OLD.Ed_Status != 1 AND NEW.Ed_Status = 1 THEN
        UPDATE Department
        SET dept_peoplecount = dept_peoplecount + 1
        WHERE dept_no = NEW.dept_no;
    END IF;
END
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
