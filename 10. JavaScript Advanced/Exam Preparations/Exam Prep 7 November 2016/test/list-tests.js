let expect = require("chai").expect;
let list = require('../02. Add and Delete from List/add-delete-in-list.js')

describe('list', function () {
  let lis;
  beforeEach(function () {
    lis = (function () {
      return list;
    })();
  });
  it("should add data of any type", function () {
    lis.add(5);
    lis.add("pesho");
    lis.add(true);
    expect(lis.toString()).to.equal("5, pesho, true");
  });
  it("should correctly delete data with correct index", function () {
    lis.add(5);
    lis.add("pesho");
    lis.add(true);
    lis.delete(1);
    expect(lis.toString()).to.equal("5, true");
  });
  it("should return correct data for remove at valid index", function () {
    lis.add(5);
    lis.add("pesho");
    lis.add(true);
    expect(lis.delete(1)).to.equal("pesho");
  });
  it("should return undefined if deleting non-integer index", function () {
    lis.add(5);
    lis.add("pesho");
    lis.add(true);
    expect(lis.delete(3.14)).to.equal(undefined);
  });
  it("should return undefined on attempt to delete negative index", function () {
    lis.add(5);
    lis.add("pesho");
    lis.add(true);
    expect(lis.delete(-2)).to.equal(undefined);
  });
  it("should return undefined on attempt to delete non-existing index", function () {
    lis.add(5);
    lis.add("pesho");
    lis.add(true);
    expect(lis.delete(5)).to.equal(undefined);
  });
  it("should correctly print data", function () {
    let array = [5, "gosho", true, false, 3.15];
    array.forEach(el => lis.add(el));
    expect(lis.toString()).to.equal(array.join(", "));
  });
});